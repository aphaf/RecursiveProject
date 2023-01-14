using RecursiveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTest
{
    public class CourseTest
    {
        [Fact]
        public void ShouldFindAllCoursePreReqs()
        {
            Course course = new Course
            {
                CourseID = 1,
                Name = "MIS452",
                //main course
                PreReqCourses = new List<PreReq>
            {
                new PreReq //first prereq
                {
                    PreReqCourse = new Course
                    {
                        Name = "MIST 450",
                        PreReqCourses = new List<PreReq>
                        {
                            new PreReq
                            {
                                PreReqCourse = new Course
                                {
                                    Name = "MIST 353",
                                    PreReqCourses = new List<PreReq>
                                    {
                                        new PreReq
                                        {
                                            PreReqCourse = new Course
                                            {
                                                Name = "MIST 352" }
                                        },
                                        new PreReq
                                        {
                                            PreReqCourse = new Course
                                            {
                                                Name = "MIST 351" }
                                        }
                                    }
                                }
                            }
                        }
                    },
                },
                new PreReq
                {
                    PreReqCourse = new Course
                    {
                        Name = "MIST 353",
                        PreReqCourses = new List<PreReq>
                        {
                            new PreReq
                            {
                                PreReqCourse = new Course
                                {
                                    Name = "MIST 352"
                                }
                            },
                            new PreReq
                            {
                                PreReqCourse = new Course
                                {
                                    Name = "MIST 351"
                                }
                            }
                        }
                    }
                }
            }
            };

            List<Course> preReqList = course.FindAllPreReqs(course);

            int expected = 4;
            int actual = preReqList.Count;

            Assert.Equal(expected, actual);
        }
    }
}
