using Microsoft.EntityFrameworkCore;
using MyTestAspNetCore.Models;

namespace MyTestAspNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<CategoryM> Categories { get; set; }
        public DbSet<OrganizationM> Organizations { get; set; }
    }
}
