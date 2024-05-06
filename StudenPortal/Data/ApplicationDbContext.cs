using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudenPortal.Models.Entities;

namespace StudenPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
