using Microsoft.EntityFrameworkCore;
using DVLD_WEB.Models;

namespace DVLD_WEB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}

