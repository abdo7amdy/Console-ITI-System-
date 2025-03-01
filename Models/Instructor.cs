using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public float Hour_Rate { get; set; }
        public int Dept_Id { get; set; }
        [ForeignKey("Dept_Id")]
        public Department Department {  get; set; }
        public ICollection<Course_Instructor> Course_Instructors { get; set; } = new HashSet<Course_Instructor>();



    }
}
