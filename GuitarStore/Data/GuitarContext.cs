using Microsoft.EntityFrameworkCore;
using GuitarStore.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GuitarStore.Data
{
    public class GuitarContext : IdentityDbContext<IdentityUser>
    {
        public GuitarContext(DbContextOptions<GuitarContext> options) : base(options)
        {
        }

        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }

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
                new Guitar { GuitarID = 1, Brand = "Fender", Description = "Stratocaster - Iconic American electric with three single-coil pickups and contoured body.", Price = 899.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/1a1a2e/ffffff&text=Fender+-+Stratocaster" },
                new Guitar { GuitarID = 2, Brand = "Gibson", Description = "Les Paul Standard - Classic rock guitar with mahogany body and twin humbucker pickups.", Price = 1299.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/16213e/ffffff&text=Gibson+-+Les+Paul" },
                new Guitar { GuitarID = 3, Brand = "Fender", Description = "Telecaster - Twangy classic with two single-coil pickups and solid ash body.", Price = 849.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/1b4332/ffffff&text=Fender+-+Telecaster" },
                new Guitar { GuitarID = 4, Brand = "Gibson", Description = "SG Standard - Lightweight double cutaway with twin humbuckers and slim taper neck.", Price = 1099.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/6b2737/ffffff&text=Gibson+-+SG+Standard" },
                new Guitar { GuitarID = 5, Brand = "Ibanez", Description = "RG550 - High performance electric with Wizard neck and Edge tremolo system.", Price = 699.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/d62828/ffffff&text=Ibanez+-+RG550" },
                new Guitar { GuitarID = 6, Brand = "PRS", Description = "Custom 24 - Versatile electric with stunning figured maple top and wide-thin neck.", Price = 2199.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/4a0e8f/ffffff&text=PRS+-+Custom+24" },
                new Guitar { GuitarID = 7, Brand = "ESP", Description = "LTD EC-1000 - Professional electric with set-thru neck and EMG pickups.", Price = 799.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/212529/ffffff&text=ESP+-+LTD+EC-1000" },
                new Guitar { GuitarID = 8, Brand = "Gretsch", Description = "G2622 Streamliner - Semi-hollow body with dual broad'tron pickups.", Price = 449.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/9c6644/ffffff&text=Gretsch+-+G2622" },
                new Guitar { GuitarID = 9, Brand = "Epiphone", Description = "Casino - Fully hollow thinline with P-90 style dogear pickups.", Price = 599.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/343a40/ffffff&text=Epiphone+-+Casino" },
                new Guitar { GuitarID = 10, Brand = "Schecter", Description = "Hellraiser C-1 - High output electric with active EMG pickups and set neck.", Price = 749.99m, CategoryID = 1, ImageUrl = "https://dummyimage.com/400x300/560bad/ffffff&text=Schecter+-+Hellraiser+C-1" },
                new Guitar { GuitarID = 11, Brand = "Martin", Description = "D-28 - Premium dreadnought acoustic with Sitka spruce top and rosewood back.", Price = 1799.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/5c4033/ffffff&text=Martin+-+D-28" },
                new Guitar { GuitarID = 12, Brand = "Taylor", Description = "214ce - Grand Auditorium acoustic-electric with a warm balanced tone.", Price = 999.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/533483/ffffff&text=Taylor+-+214ce" },
                new Guitar { GuitarID = 13, Brand = "Gibson", Description = "J-45 Standard - Slope-shouldered dreadnought with warm vintage tone.", Price = 1599.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/3d1f00/ffffff&text=Gibson+-+J-45" },
                new Guitar { GuitarID = 14, Brand = "Yamaha", Description = "FG800 - Solid Sitka spruce top dreadnought with scalloped bracing.", Price = 249.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/2b2d42/ffffff&text=Yamaha+-+FG800" },
                new Guitar { GuitarID = 15, Brand = "Seagull", Description = "S6 Original - Canadian-made acoustic with cedar top and cherry back.", Price = 399.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/4a7c59/ffffff&text=Seagull+-+S6+Original" },
                new Guitar { GuitarID = 16, Brand = "Takamine", Description = "GN93CE - NEX body acoustic-electric with solid cedar top and rosewood.", Price = 549.99m, CategoryID = 2, ImageUrl = "https://dummyimage.com/400x300/774936/ffffff&text=Takamine+-+GN93CE" },
                new Guitar { GuitarID = 17, Brand = "Yamaha", Description = "CG182S - Classical with solid Engelmann spruce top and warm projecting sound.", Price = 449.99m, CategoryID = 3, ImageUrl = "https://dummyimage.com/400x300/2b2d42/ffffff&text=Yamaha+-+CG182S" },
                new Guitar { GuitarID = 18, Brand = "Cordoba", Description = "C9 Parlour - Solid cedar top classical with mahogany back and sides.", Price = 599.99m, CategoryID = 3, ImageUrl = "https://dummyimage.com/400x300/5e3023/ffffff&text=Cordoba+-+C9+Parlour" },
                new Guitar { GuitarID = 19, Brand = "Kremona", Description = "Soloist S65C - Bulgarian handcrafted classical with solid cedar top.", Price = 349.99m, CategoryID = 3, ImageUrl = "https://dummyimage.com/400x300/1b4332/ffffff&text=Kremona+-+Soloist+S65C" },
                new Guitar { GuitarID = 20, Brand = "Alhambra", Description = "3C - Spanish classical with solid Canadian cedar top and sapele back.", Price = 499.99m, CategoryID = 3, ImageUrl = "https://dummyimage.com/400x300/6d4c41/ffffff&text=Alhambra+-+3C" }
            );
        }
    }

    public class GuitarContextFactory : IDesignTimeDbContextFactory<GuitarContext>
    {
        public GuitarContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GuitarContext>();
            optionsBuilder.UseSqlite("Data Source=guitarstore.db");
            return new GuitarContext(optionsBuilder.Options);
        }
    }
}