using FizzWare.NBuilder;
using HR.Domain.Entities;

namespace HR.Data
{
    public interface IEmployeeRepository : IRepository<Employee>
    {

    }

    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>();

            for(int i=0; i<2000; i++)
            {
                var e = Builder<Employee>.CreateNew().Build();
                e.Id = i;
                _employees.Add(e);
                
            }
        }

        public Employee Add(Employee entity)
        {
            if(_employees.Any(s => s.Id == entity.Id || (s.LastName == entity.FirstName && s.FirstName == entity.LastName)))
            {
                throw new Exception("UserFoundException");
            }

            _employees.Add(entity);
            return entity;
        }

        public bool DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            var e = GetById(id);
            return _employees.Remove(e);
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee? GetById(int id)
        { 
            return _employees.SingleOrDefault(e=>e.Id== id);  
        }

        public bool Update(Employee entity)
        {
            var e = _employees.Single(e => e.Id == entity.Id);
            e.Address = entity.Address;
            e.FirstName = entity.FirstName;
            e.LastName = entity.LastName;    
            e.PostalCode = entity.PostalCode;

            return true;
        }
    }
}
