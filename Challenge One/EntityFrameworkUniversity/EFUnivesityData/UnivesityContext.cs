using EFUnivesityDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityData
{
    public class UnivesityContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-KAP3NP1H; Initial Catalog=UniversityTwo; persist security info=True; Integrated Security=SSPI;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();  //to use sql server, connection string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //ADD VALIDATION TO OUR TABLES
            //Student Validations
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            // Instructor Validations
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            // Deparment Validations
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            // OfficeAssignment
            modelBuilder.ApplyConfiguration(new OfficeAssignmentConfiguration());
            // Course
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            // Course Assignment
            modelBuilder.ApplyConfiguration(new CourseAssignmentConfiguration());
            // Enrollment
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
        }


        // Adding tables
        public DbSet<Student> Students { get; set; } 
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public  DbSet<Course> Courses { get; set; } = null!;
        public  DbSet<CourseAssignment> CourseAssignments { get; set; } 
        public  DbSet<Enrollment> Enrollments { get; set; }
       
       
       


    }
}
