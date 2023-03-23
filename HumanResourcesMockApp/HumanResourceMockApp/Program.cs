using HR.Data;
using HR.Domain.Entities;
using HR.Services;
using System;

namespace HumanResourceMockApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var empRepo = new EmployeeRepository();
            var hr = new HRServices(empRepo);
            while (true)
            {
                hr.UpdateEmployeeAddress(empRepo.GetById(1));
            }
        }
    }
}