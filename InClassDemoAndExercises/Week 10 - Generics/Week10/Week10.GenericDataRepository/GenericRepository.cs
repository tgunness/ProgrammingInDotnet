using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week10.GenericRepositoryExercise
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private List<T> _data;

        public GenericRepository()
        {
            _data = new List<T>();
        }

        public GenericRepository(List<T> entities)
        {
            _data = entities;
        }

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            _data.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _data.Remove(entity);
        }

        public void Delete(int id)
        {
            foreach (var element in _data)
            {
                Type t = element.GetType();
                PropertyInfo prop = t.GetProperty("ID");
                int elementId = (int)prop.GetValue(element);
                if (elementId == id)
                {
                    _data.Remove(element);
                    break;
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            foreach (var element in _data)
            {
                Type t = element.GetType();
                PropertyInfo prop = t.GetProperty("ID");
                int elementId = (int)prop.GetValue(element);
                if (elementId == id)
                {
                    return element;
                }
            }
            return null;
        }

        public void Update(T entity)
        {
            var oldElement = _data.First(a => a.Equals(entity));
            if (oldElement != null)
            {
                oldElement = entity;
            }
        }
    }
}
