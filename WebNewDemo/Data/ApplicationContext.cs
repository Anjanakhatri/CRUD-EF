using Microsoft.EntityFrameworkCore;
using WebNewDemo.Models;

namespace WebNewDemo.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee> Employee { get; set; }
    }
}
