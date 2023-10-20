using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    public class mvcDemoDbContext : DbContext
    {
        public mvcDemoDbContext(DbContextOptions options) : base(options) 
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
