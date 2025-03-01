using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Instructor_Id { get; set; }
        [ForeignKey("Instructor_Id")]
        public Instructor Instructor { get; set; }
        public DateTime Hiring_Date { get; set; }
         
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Instructor> Instructors { get; set;} = new HashSet<Instructor>();


    }
}
