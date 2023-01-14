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
            Course main = new Course(1, "452");
            Course c450 = new Course(2, "450");
            Course c353 = new Course(3, "353");
            Course c352 = new Course(4, "352");
            Course c351 = new Course(5, "351");

            c353.PreReqCourses.Add(new PreReq { Course = c353, PreReqCourse = c352 });
            c353.PreReqCourses.Add(new PreReq { Course = c353, PreReqCourse = c351 });

            c450.PreReqCourses.Add(new PreReq { Course = c450, PreReqCourse = c353 });

            main.PreReqCourses.Add(new PreReq { Course = main, PreReqCourse = c450 });
            main.PreReqCourses.Add(new PreReq { Course = main, PreReqCourse = c353 });

            List<Course> preReqList = main.FindAllPreReqs(main, new List<Course>());

            int expected = 4;
            int actual = preReqList.Count;

            Assert.Equal(expected, actual);
        }
    }
}
