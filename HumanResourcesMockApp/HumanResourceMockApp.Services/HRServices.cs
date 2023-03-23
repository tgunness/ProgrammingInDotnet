using HR.Data;
using HR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR.Services
{
    public class HRServices
    {
        private IEmployeeRepository _employeeRepo { get; }

        public HRServices(IEmployeeRepository employeeRepo) 
        {
            _employeeRepo = employeeRepo;

        }


        public Employee AddNewEmployee(Employee e)
        {
            Employee existingEmployee = _employeeRepo.GetById(e.Id);
            if (existingEmployee == null)
            {
                return _employeeRepo.Add(e);
            }
            throw new Exception("User found");
        }

        public bool UpdateEmployeeAddress(Employee e)
        {
            if (_employeeRepo.GetById(e.Id) != null)
            {
                if (IsValidPostalCode(e.PostalCode))
                {
                    return _employeeRepo.Update(e);
                }
            }
            

            throw new ArgumentException("Not a valid postal code");
        }

        private bool IsValidPostalCode(string postalcode)
        {
            string postalCodeRegex = "^[A-Z]{1}[0-9]{1}[A-Z]{1}[ ]?[0-9]{1}[A-Z]{1}[0-9]{1}$";
            return Regex.IsMatch(postalcode,postalCodeRegex);
        }

    }
}
