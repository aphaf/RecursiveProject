using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RecursiveLibrary
{
    public class PreReq
    {
        [Key]
        public int PreReqID { get; set; }

        [Required]
        public int PreReqCourseID { get; set; }
        [ForeignKey("PreReqCourseID")]
        public Course PreReqCourse { get; set; }

        public int CourseID { get; set; }
        [NotMapped]
        [ForeignKey("CourseID")]
        public Course Course { get; set; }

        public PreReq(int preReqID, int preReqCourseID, int courseID)
        {
            PreReqID = preReqID;
            PreReqCourseID = preReqCourseID;
            CourseID = courseID;
        }

        public PreReq()
        {

        }
    }
}