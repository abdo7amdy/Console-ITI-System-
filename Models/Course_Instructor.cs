using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Models
{
    public class Course_Instructor
    {
        public int InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }        
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public string Evaluate { get; set; }


    }
}
