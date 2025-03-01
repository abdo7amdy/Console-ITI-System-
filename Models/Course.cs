using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public int? TopicId { get; set; }
        [ForeignKey("TopicId")]
        public Topic? Topic { get; set; }
        public ICollection<Student_Course>? StudentCourses { get; set; } = new HashSet<Student_Course>();
        public ICollection<Course_Instructor>? CourseInstructors { get; set; } = new HashSet<Course_Instructor>();


    }
}
