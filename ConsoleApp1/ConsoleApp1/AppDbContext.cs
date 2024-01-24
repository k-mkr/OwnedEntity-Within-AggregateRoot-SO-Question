using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DocumentDB;TrustServerCertificate=True;Trusted_Connection=True;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .OwnsMany(x => x.Versions);

            modelBuilder.Entity<Document>()
                .OwnsOne(x => x.LatestVersion, prop =>
                {
                    prop.Ignore(x => x.Version);
                    prop.Ignore(x => x.CreatedDate);
                });
        }
    }
}
