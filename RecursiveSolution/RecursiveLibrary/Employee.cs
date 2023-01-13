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
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int? SupervisorID { get; set; }
        [ForeignKey("SupervisorID")]
        public Employee? Supervisor { get; set; }

        public List<Employee>? ListOfSupervisors { get; set; }


        


            /*
             public List<int> FindFibonacciNumbers(int num)
        {
            //termination condition
            //when num hits 1 it stops the recurs (runs 6 based on test times)
            if (num == 1)
            {
                return new List<int>() { 1 };
                //creates list with first fibonacci number
            }
            //recursive call
            else
            {
                List<int> list = FindFibonacciNumbers(num - 1);
                //calls method 6 times (based on test), basically nesting within itself

                if (list.Count == 1)
                //if the list has 1 value (the first fibonacci number)
                {
                    //adds the first index (1) with itself, and adds it (2) to the list
                    list.Add(list[0] + list[0]);
                }
                else
                {
                    int n = list.Count - 2;
                    //variable n used during debugging, could just put this within the add method below
                    //list.count - 2 is to find the index before the last index, index is 0 based counting, have to subtract by 2

                    list.Add(list[n] + list.Last());
                    //adding the 2nd to last element and the last element together, adding the new value to the list

                    /*
                    example using 2nd run
                        num = 2
                        list.count = 2

                        n = 0 
                        
                        list[0] + list[1] == 1 + 2 = 3
                    
                     */


        /*
        2. Course (Id, name). Each course has none, one or more prerequisites. Each course is the prerequisite for none, one or more courses. Design a recursive method: Given a course, list its entire chain of prerequisite courses.
        
         */
    }
}