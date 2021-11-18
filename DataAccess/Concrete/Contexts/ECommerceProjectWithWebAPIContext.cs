using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Contexts
{
    public class ECommerceProjectWithWebAPIContext:DbContext
    {
        public ECommerceProjectWithWebAPIContext(DbContextOptions<ECommerceProjectWithWebAPIContext> options):base(options)
        {

        }

        public ECommerceProjectWithWebAPIContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            string connString = "Data Source=.;Initial Catalog=ECommerceProjectWithWebAPIDb;Trusted_Connection=TRUE;";
            optionsBuilder.UseSqlServer(connString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
