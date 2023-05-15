using ISU_BT_PROJECT.Models;
using Microsoft.EntityFrameworkCore;

namespace ISU_BT_PROJECT.Data
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options)
    : base(options)
        {

        }

        public DbSet<BTUser> Users { get; set; }

        public DbSet<ContactForm> ContactForms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BTUser>(entity => {
                entity.HasKey(k => k.id);
            });

            base.OnModelCreating(builder);
            builder.Entity<ContactForm>(entity => {
                entity.HasKey(k => k.id);
            });
        }
    }
}
