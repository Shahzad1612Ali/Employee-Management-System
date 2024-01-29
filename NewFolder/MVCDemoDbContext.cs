using GymManagment.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.NewFolder
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } 
    }
}
