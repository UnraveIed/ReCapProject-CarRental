using CarRental.DataAccess.Concrete.EntityFramework.Mappings;
using CarRental.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Concrete.EntityFramework.Contexts
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString: @"server=BATU\SQLEXPRESS; database=CarRental; Trusted_Connection=True; Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new ColorMap());
            modelBuilder.ApplyConfiguration(new CarMap());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
