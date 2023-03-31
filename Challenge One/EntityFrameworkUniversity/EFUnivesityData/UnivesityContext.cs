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
            // -- Varchar Sizes --
            //Student Validations
            modelBuilder.Entity<Student>().Property(p => p.LastName).HasMaxLength(25);
            modelBuilder.Entity<Student>().Property(p => p.FirstMidName).HasMaxLength(25);
            // Instructor Validations
            modelBuilder.Entity<Instructor>().Property(p => p.LastName).HasMaxLength(25);
            modelBuilder.Entity<Instructor>().Property(p => p.LastName).HasMaxLength(25);
            // Instructor Validations
            modelBuilder.Entity<Department>().Property(p => p.Name).HasMaxLength(25);
            // OfficeAssignment
            modelBuilder.Entity<OfficeAssignment>().Property(p => p.Location).HasMaxLength(25);
            // Course
            modelBuilder.Entity<Course>().Property(p => p.Title).HasMaxLength(25);


            // -- Indexes --
            modelBuilder.Entity<Enrollment>().HasIndex(h => h.CourseId);
            modelBuilder.Entity<Course>().HasIndex(h => h.DepartmentId);
            modelBuilder.Entity<Department>().HasIndex(h => h.InstructorId);
            modelBuilder.Entity<Enrollment>().HasIndex(h => new { h.CourseId, h.StudentId } );

            // No Keys
            modelBuilder.Entity<CourseAssignment>().HasNoKey();
            modelBuilder.Entity<OfficeAssignment>().HasNoKey();
            //SEEDING DATA
            // Student
            modelBuilder.Entity<Student>().HasData(
                    new Student { Id = 1, LastName = "Che", FirstMidName = "Carlos", EnrollmentDate = DateTime.Now },
                    new Student { Id = 2, LastName = "Mijangos", FirstMidName = "Agustin", EnrollmentDate = DateTime.Now }
                );

            // Instructor
            modelBuilder.Entity<Instructor>().HasData(
                     new Instructor { Id = 1, LastName = "Solares", FirstMidName = "Juan",  HireDate = DateTime.Now }
            );

            

            // Department
            modelBuilder.Entity<Department>().HasData(
                    new Department { DepartmentId = 1, Name = "Engenierr", Budget = 90000, StartDate = DateTime.Now, InstructorId = 1}
           );

            // Course
            modelBuilder.Entity<Course>().HasData(
                    new Course { CourseId = 1, Title = "Progra 1", Credits = 5, DepartmentId = 1 },
                    new Course { CourseId = 2, Title = "Progra 2", Credits = 4, DepartmentId = 1 }
            );

            // Enrollment
            modelBuilder.Entity<Enrollment>().HasData(
                   new Enrollment { EnrollmentId = 1, CourseId = 1, StudentId = 1, Grade = 50},
                   new Enrollment { EnrollmentId = 2, CourseId = 1, StudentId = 2, Grade = 80 },
                   new Enrollment { EnrollmentId = 3, CourseId = 2, StudentId = 2, Grade = 70 }
            );

           


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
