using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public int Dept_Id { get; set; }
        [ForeignKey("Dept_Id")]
        public Department? Department { get; set; }
        public ICollection<Student_Course>? Student_Courses { get; set; } = new HashSet<Student_Course>();


    }
}
