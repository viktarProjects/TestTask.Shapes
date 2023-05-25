using Microsoft.EntityFrameworkCore;
using TestTask.Data.Models;

namespace TestTask.Data.DataContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base()
        {
        }

        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            base.OnModelCreating(builder);
        }
    }
}
