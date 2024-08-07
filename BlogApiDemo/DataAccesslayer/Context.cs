using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccesslayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AO5K0VF;database=CoreBlogApiDb; integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
