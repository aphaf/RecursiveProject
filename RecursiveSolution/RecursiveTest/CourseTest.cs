using RecursiveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTest
{
    public class CourseTest
    {
        [Fact]
        public void ShouldFindAllCoursePreReqs()
        {
            List<Course> mockCourses = CreateMockCourses();

            //List<Course> preReqList = course.FindAllPreReqs(course, new List<Course>());

            int expected = 4;
            int actual = mockCourses.Last().FindAllPreReqs(new List<Course>()).Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldNotFindCoursePreReq()
        {
            List<Course> mockCourses = CreateMockCourses();

            //List<Course> preReqList = course.FindAllPreReqs(course, new List<Course>());

            int expected = 0;
            int actual = mockCourses.First().FindAllPreReqs(new List<Course>()).Count;

            Assert.Equal(expected, actual);
        }

        public List<Course> CreateMockCourses()
        {
            List<Course> mockCourses = new List<Course>();

            Course course = new Course
            {
                CourseID = 1,
                Name = "351",
            };
            mockCourses.Add(course);

            course = new Course
            {
                CourseID = 3,
                Name = "353",
                PreReqCourses = new List<Course>
                {
                    course,
                    new Course(2, "352")
                }
            };
            List<Course> preReqsFor452 = new List<Course> { course };
            mockCourses.Add(course);

            course = new Course
            {
                CourseID = 4,
                Name = "450",
                PreReqCourses = new List<Course> { course } 
            };
            preReqsFor452.Add(course);
            mockCourses.Add(course);

            course = new Course
            {
                CourseID = 5,
                Name = "452",
                PreReqCourses = new List<Course> 
                { preReqsFor452[0], preReqsFor452[1] }
            };
            mockCourses.Add(course);

            return mockCourses;
        }


        /*public List<Course> CreateMockCourses()
        {
            List<Course> mockCourses = new List<Course>();

            Course course = new Course
            {
                CourseID = 1,
                Name = "351",
            };
            mockCourses.Add(course);

            course = new Course
            {
                CourseID = 3,
                Name = "353",
                PreReqCourses = new List<PreReq>
                {
                    new PreReq { PreReqCourse = course },
                    new PreReq { PreReqCourse = new Course(2, "352") }
                }
            };
            List<Course> preReqsFor452 = new List<Course> { course };
            mockCourses.Add(course);

            course = new Course
            {
                CourseID = 4,
                Name = "450",
                PreReqCourses = new List<PreReq>
                {
                    new PreReq { PreReqCourse = course }
                }
            };
            preReqsFor452.Add(course);
            mockCourses.Add(course);

            course = new Course 
            { 
                CourseID = 5,
                Name = "452",
                PreReqCourses = new List<PreReq> { new PreReq { PreReqCourse = preReqsFor452[0] }, new PreReq { PreReqCourse = preReqsFor452[1] } }
            };
            mockCourses.Add(course);

            return mockCourses;



            //Course c452 = new Course(1, "452");
            //c452.PreReqCourses.Add(new PreReq { Course = c452, PreReqCourse = c353 });
            //c452.PreReqCourses.Add(new PreReq { Course = c452, PreReqCourse = c353 });


            //Course c353 = new Course(3, "353");
            //Course c352 = new Course(4, "352");
            //Course c351 = new Course(5, "351");

            //c353.PreReqCourses.Add(new PreReq { Course = c353, PreReqCourse = c352 });
            //c353.PreReqCourses.Add(new PreReq { Course = c353, PreReqCourse = c351 });


            //Course c450 = new Course(2, "450");
            //c450.PreReqCourses.Add(new PreReq { Course = c450, PreReqCourse = c353 });


            //Course main = new Course(1, "452");
            //main.PreReqCourses.Add(new PreReq { Course = main, PreReqCourse = c450 });
            //main.PreReqCourses.Add(new PreReq { Course = main, PreReqCourse = c353 });

        }*/
    }
}
