using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Week12.InClassDemo.DataAccessLayer
{
    public interface IGenericRepository<T> where T : class, new()
    {
        IEnumerable<T> GetAll();
        T Get(string privateKeyColumnName, object id);
    }


    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DataContext _context;
        private readonly Table<T> _table;
        public GenericRepository(DataContext context)
        {
            _context = context;
            _table = context.GetTable<T>();
        }

        public T Get(string privateKeyColumnName, object id)
        {
            return _table.SingleOrDefault(e => e.GetType().GetProperty(privateKeyColumnName).GetValue(e).Equals(id));
        }
        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
    }
}
