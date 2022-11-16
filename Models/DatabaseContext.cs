using Microsoft.EntityFrameworkCore;

namespace StudentProgressReportSystem.Models
{
    
        public class DatabaseContext : DbContext
        {

            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)

            {

            }
            public DbSet<Student>Students { get; set; }
            public DbSet<Progress>progress { get; set; }
        public object Progress { get; internal set; }
    }
    }
