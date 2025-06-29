using Microsoft.EntityFrameworkCore;
using GuitarStore.Models;
using System.Data.Common;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GuitarStore.Data
{
    public class GuitarContext : DbContext
    {
        public GuitarContext(DbContextOptions<GuitarContext> options) : base(options)
        { 
        }

        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> orderedItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Guitar>().ToTable("Guitar");

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Type = "Electric" },
                new Category { CategoryID = 2, Type = "Acoustic" },
                new Category { CategoryID = 3, Type = "Classical" }
             );

            modelBuilder.Entity<OrderedItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderID);

            modelBuilder.Entity<OrderedItem>()
                .HasOne(oi => oi.Guitar)
                .WithMany()
                .HasForeignKey(oi => oi.GuitarID);

            modelBuilder.Entity<Guitar>().HasData(
                new Guitar
                {
                    GuitarID = 1,
                    Brand = "Fender",
                    Price = 899.99m,
                    CategoryID = 1,
                    ImageUrl = "https://commons.wikimedia.org/wiki/Category:Fender_Stratocaster#/media/File:Fender_Highway_1_Stratocaster.jpg"
                }
            );
            
        }

    }
    public class GuitarContextFactory : IDesignTimeDbContextFactory<GuitarContext>
    {
        public GuitarContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<GuitarContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new GuitarContext(optionsBuilder.Options);
        }
    }
}
