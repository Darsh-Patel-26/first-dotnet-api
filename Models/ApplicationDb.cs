using Microsoft.EntityFrameworkCore;

namespace DriversApi.Models
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
    }
}
