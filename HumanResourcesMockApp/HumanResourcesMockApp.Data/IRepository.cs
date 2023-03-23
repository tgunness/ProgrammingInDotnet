using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Data
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        bool DeleteById(int id);
        bool Update(T entity);
        bool DeleteAll();
        T Add(T entity);
    }
}
