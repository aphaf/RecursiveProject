using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RecursiveLibrary
{
    public class Course
    {
        /*
        2. Course (Id, name). 
        Each course has none, one or more prerequisites. 
        Each course is the prerequisite for none, one or more courses. 
        
        Design a recursive method: 
            Given a course, list its entire chain of prerequisite courses.
        
         */

        [Key]
        public int CourseID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<PreReq> PreReqCourses { get; set; }

        public Course(int courseID, string name)
        {
            CourseID = courseID;
            Name = name;
            PreReqCourses = new List<PreReq>();
        }

        public Course()
        {
            PreReqCourses = new List<PreReq>();
        }

        public List<Course> FindAllPreReqs(Course course, List<Course> allPreReqs)
        {
            foreach (PreReq preReq in course.PreReqCourses)//for each preReq in course prereq list
            {
                allPreReqs = FindAllPreReqs(preReq.PreReqCourse, allPreReqs);//recursive call
                allPreReqs.Add(preReq.PreReqCourse);//add the pre req to the course
            }

            return allPreReqs.Distinct().ToList();//find all distinct values (each individual course) and return that list

            //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct?view=net-7.0
            //https://stackoverflow.com/questions/10255121/get-a-list-of-distinct-values-in-list


            //if (course.PreReqCourses.Any())//if course prereq list has anything (course has prereq)
            //{
            //    foreach (PreReq preReq in course.PreReqCourses)//for each preReq in course prereq list
            //    {
            //        allPreReqs = FindAllPreReqs(preReq.PreReqCourse, allPreReqs);//recursive call
            //        if (!allPreReqs.Contains(preReq.PreReqCourse))//if allprereq list does not have this course, add it
            //        {
            //            allPreReqs.Add(preReq.PreReqCourse);
            //        }
            //    }
            //}
            //else//(course does not have prereq)
            //{
            //    if (!allPreReqs.Contains(course) && allPreReqs.Any())
            //        //if allprereq list does not have this course, and allprereq has something in it, add this course
            //    {
            //        allPreReqs.Add(course);
            //    }
            //}
        }
    }
}