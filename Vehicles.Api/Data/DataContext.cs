using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vehicles.Api.Data.Entities;

namespace Vehicles.Api.Data
{
    public class DataContext: IdentityDbContext<User>
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

            public DbSet<VehicleType> VehicleTypes { get; set; }
            public DbSet<Procedure> Procedures { get; set; }
         public DbSet<Brand> Brands { get; set; }
            public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique(); 
            modelBuilder.Entity<Procedure>().HasIndex(y => y.Description).IsUnique();
            modelBuilder.Entity<Brand>().HasIndex(x => x.Description).IsUnique(); 
            modelBuilder.Entity<DocumentType>().HasIndex(y => y.Description).IsUnique();
        }
    }
    }


