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
            Employee employee = new Employee
            {
                EmployeeID = 1,
                Name = "Penguin",
                Supervisor = new Employee
                {
                    EmployeeID = 2,
                    Name = "Pig",
                    Supervisor = new Employee
                    {
                        EmployeeID = 3,
                        Name = "Giraffe",
                        Supervisor = new Employee
                        {
                            EmployeeID = 4,
                            Name = "Flamingo"
                        }
                    }
                }
            };

            List<Employee> supervisorList = employee.FindAllSupervisors(employee);

            int expected = 3;
            int actual = supervisorList.Count();

            Assert.Equal(expected, actual);
        }
    }
}
