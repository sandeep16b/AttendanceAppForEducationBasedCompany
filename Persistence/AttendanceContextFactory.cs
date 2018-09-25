
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AttendanceAppForEducationBasedCompany.Persistence
{
    public class AttendanceContextFactory : IDesignTimeDbContextFactory<AttendanceDbContext>
    {
        AttendanceDbContext IDesignTimeDbContextFactory<AttendanceDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AttendanceDbContext>();
            optionsBuilder.UseSqlServer<AttendanceDbContext>("server=localhost; database=MyAttendance; user id=sa; password=MyComplexPassword!234");

            return new AttendanceDbContext(optionsBuilder.Options);
        }
    }
}

