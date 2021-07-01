using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.DataAccess.Data
{
    public class VehiclesDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<WheelDrive> WheelDrives { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }


        public VehiclesDbContext()
        {
            
        }

        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            //bir filmin bir türü var
            modelBuilder.Entity<Vehicle>()
                .HasOne(m => m.Model)
                .WithMany()
                .HasForeignKey(m => m.ModelId)
                .OnDelete(DeleteBehavior.NoAction);  //bir tür silinirse o türe bağlı tüm filmler silinecek Noaction tam tersi onay vermez.

            modelBuilder.Entity<Vehicle>()
                .HasOne(m => m.Series)
                .WithMany()
                .HasForeignKey(m => m.SeriesId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
