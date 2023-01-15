using RecursiveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTest
{
    public class EmployeeTest
    {
        [Fact]
        public void ShouldFindEmployeeSupervisors()
        {
            List<Employee> mockEmployees = CreateMockEmployees();

            //List<Employee> supervisorList = employee.FindAllSupervisors(employee);

            int expected = 3;
            int actual = mockEmployees.Last().FindAllSupervisors(mockEmployees.Last()).Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldFindNoEmployeeSupervisors()
        {
            List<Employee> mockEmployees = CreateMockEmployees();

            int expected = 0;
            int actual = mockEmployees.First().FindAllSupervisors(mockEmployees.First()).Count;

            Assert.Equal(expected, actual);
        }

        public List<Employee> CreateMockEmployees()
        {
            List<Employee> mockEmployees = new List<Employee>();

            Employee employee = new Employee
            {
                EmployeeID = 1,
                Name = "Flamingo"
            };
            mockEmployees.Add(employee);

            employee = new Employee
            {
                EmployeeID = 2,
                Name = "Giraffe",
                Supervisor = employee
            };
            mockEmployees.Add(employee);

            employee = new Employee
            {
                EmployeeID = 2,
                Name = "Pig",
                Supervisor = employee
            };
            mockEmployees.Add(employee);

            employee = new Employee
            {
                EmployeeID = 2,
                Name = "Penguin",
                Supervisor = employee
            };
            mockEmployees.Add(employee);

            //Employee employee = new Employee
            //{
            //    EmployeeID = 1,
            //    Name = "Penguin",
            //    Supervisor = new Employee
            //    {
            //        EmployeeID = 2,
            //        Name = "Pig",
            //        Supervisor = new Employee
            //        {
            //            EmployeeID = 3,
            //            Name = "Giraffe",
            //            Supervisor = new Employee
            //            {
            //                EmployeeID = 4,
            //                Name = "Flamingo"
            //            }
            //        }
            //    }
            //};

            return mockEmployees;
        }
    }
}
