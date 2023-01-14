using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveLibrary
{
    public class Fibonacci
    {
        /* leetcode recursion definition
            Principle of recursion
               Recursion is an approach to solving problems using a function that calls itself as a subroutine
               Each time a resursive function calls itself, it reduces the given problem into subproblems

            Recursive functions should have a base case and set of rules to prevent infinite loops
               1. simple base case(s) - a terminating scenario that does not use recursion
               2. a set of rules (recurrence relation) that reduces all other cases towards the base case
        */


        //3. design a recursive method to generate Fibonacci numbers(for n = 6 - provide 1, 2, 3, 5, 8, 13).

        public List<int> FindFibonacciNumbers(int num)
        {
            List<int> numbers = new List<int>();

            //termination condition
            //when num hits 1 it stops the recurs (runs 6 based on test times)
            if (num == 1)
            {
                numbers.Add(1);
                //add first fibonacci number
            }
            //recursive call
            else
            {
                numbers = FindFibonacciNumbers(num - 1);
                //calls method 6 times (based on test), basically nesting within itself

                if (numbers.Count == 1)
                //if the list has 1 value (the first fibonacci number)
                {
                    //adds the first index (1) with itself, and adds it (2) to the list
                    numbers.Add(numbers[0] + numbers[0]);
                }
                else
                {
                    int n = numbers.Count - 2;
                    //variable n used during debugging, could just put this within the add method below
                    //list.count - 2 is to find the index before the last index, index is 0 based counting, have to subtract by 2

                    numbers.Add(numbers[n] + numbers.Last());
                    //adding the 2nd to last element and the last element together, adding the new value to the list

                    /*
                    example using 2nd run based on inputting 6 to the method
                        num = 2
                        list.count = 2

                        n = 0 
                        
                        list[0] + list[1] == 1 + 2 = 3
                     */
                }
            }
            return numbers;
        }



        /* solved with a loop
         
          public List<int> FibNum(int number)
            {
                int value = 1;
                List<int> list = new List<int>();

                for (int i = 0; list.Count < number; i++)
                {
                    list.Add(value);
                    if (list.Count > 1)
                    {
                        value += list[i -1];
                    }
                    else
                    {
                        value += list[i];
                    }
                }

                return list;
            }
         */
    }
}