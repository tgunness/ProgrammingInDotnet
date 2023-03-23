using HR.Data;
using HR.Domain.Entities;
using HR.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Tests.Unit
{
    [TestClass]
    public class HRServicesTest
    {
        Mock<IEmployeeRepository> _employeeRepository;
        HRServices _hr;

        public HRServicesTest()
        {
            _employeeRepository = new Mock<IEmployeeRepository>();
            _hr = new HRServices(_employeeRepository.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"User found")]
        public void AddNewEmployee_WithExistingUser()
        {
            var existingEmployee = new Employee(1, "a", "b", "c", "d");
            _employeeRepository.Setup(s => s.GetById(It.IsAny<int>())).Returns(existingEmployee);

            _hr.AddNewEmployee(existingEmployee);
        }

        [TestMethod]
        public void AddNewEmployee_WithNewUser()
        {
            var newEmployee = new Employee(1, "a", "b", "c", "d");
            _employeeRepository.Setup(s => s.GetById(It.IsAny<int>())).Returns<Employee>(null);
            _hr.AddNewEmployee(newEmployee);
        }

        [TestMethod]
        public void UpdateEmployeeAddress_WithValidAddress()
        {
            var emp = new Employee(1, "a", "b", "c", "d");
            var updateEmp = new Employee(1, "a", "b", "c", "L8L3C3");

            _employeeRepository.Setup(s => s.GetById(It.IsAny<int>())).Returns(emp);
            _employeeRepository.Setup(s => s.Update(It.IsAny<Employee>())).Returns(true);

            var ret = _hr.UpdateEmployeeAddress(updateEmp);

            Assert.IsTrue(ret);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Not a valid postal code")]
        public void UpdateEmployeeAddress_WithInValidAddress()
        {
            var emp = new Employee(1, "a", "b", "c", "d");
            var updateEmp = new Employee(1, "a", "b", "c", "dfddfddd");

            _employeeRepository.Setup(s => s.GetById(It.IsAny<int>())).Returns(emp);
            _employeeRepository.Setup(s => s.Update(It.IsAny<Employee>())).Returns(true);

            var ret = _hr.UpdateEmployeeAddress(updateEmp);

            Assert.IsTrue(ret);
        }

    }
}
