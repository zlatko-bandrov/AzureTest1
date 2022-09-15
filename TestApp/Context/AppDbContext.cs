using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
