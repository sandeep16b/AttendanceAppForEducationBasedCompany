using MyApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AttendanceAppForEducationBasedCompany.Persistence
{
    public class AttendanceDbContext : DbContext
    {
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options)
        : base(options)
        {}
              public DbSet<Division> Divisions { get; set; }
             public DbSet<Location> Locations { get; set; }
              

              public DbSet<Subject> Subjects { get; set; }
              public DbSet<Category> Categories { get; set; }
              public DbSet<SubCategory> SubCategories { get; set; }
              public DbSet<Course> Courses { get; set; }


              public DbSet<Class> Classes { get; set; }
              public DbSet<ClassType> ClassTypes { get; set; }

              public DbSet<Student> Students { get; set; }
              public DbSet<Parent> Parents { get; set; }


              public DbSet<Enrollment> Enrollments { get; set; }
               public DbSet<EnrollmentDuration> EnrollmentDurations { get; set; }

       
    }

    
}