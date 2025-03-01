using ITI_System.Configurations;
using ITI_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Contexts
{
    public class ITIDbContext : DbContext
        {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A1088VT\\ABDOHAMDY;Database=ITI_EF_CORE;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Course_Instructor>()
                .HasKey(ci => new { ci.InstructorId, ci.CourseId });

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany() // No navigation property on Instructor
                .HasForeignKey(d => d.Instructor_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors) // An Instructor belongs to a department, and a department can have multiple instructors
                .HasForeignKey(i => i.Dept_Id)
                .OnDelete(DeleteBehavior.NoAction);
            // Precision for Salary
            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasPrecision(18, 4);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course> StudentCourses { get; set; }
        public DbSet<Course_Instructor> CourseInstructors { get; set; }
        }
}
