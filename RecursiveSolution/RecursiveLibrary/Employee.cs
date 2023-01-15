using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace RecursiveLibrary
{
    public class Employee
    {
        /*
        1. Employee (Id, name). 
        Each employee has a supervisor. 
        Each supervisor can supervise multiple employees (supervisors are also employees). 
        Design the class diagram. 
        
        Design a recursive method: 
            Given a employee, list the entire chain of his / her supervisors.
        */

        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        

        public int? SupervisorID { get; set; }
        [ForeignKey("SupervisorID")]
        public Employee? Supervisor { get; set; }

        public List<Employee>? ListOfEmployees { get; set; }

        public Employee(int employeeID, string name)
        {
            EmployeeID = employeeID;
            Name = name;
            ListOfEmployees = new List<Employee>();
        }
        public Employee()
        {
            ListOfEmployees = new List<Employee>();
        }

        public List<Employee> FindAllSupervisors(Employee employee, List<Employee> allSupervisors)
        {
            //List<Employee> allSupervisors = new List<Employee>();

            //termination condition
            if (employee.Supervisor != null)
            {
                //recursion call
                //call the method until no supervisor is found^^
                allSupervisors = FindAllSupervisors(employee.Supervisor, allSupervisors);

                //add the supervisor of employee
                allSupervisors.Add(employee.Supervisor);
            }

            return allSupervisors;
        }
    }
}