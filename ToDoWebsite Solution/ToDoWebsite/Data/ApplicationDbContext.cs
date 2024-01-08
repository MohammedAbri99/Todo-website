using Microsoft.EntityFrameworkCore;
using ToDoWebsite.Models;
namespace ToDoWebsite.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTask>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ToDoTask> tasks { get; set; }
    }
}
