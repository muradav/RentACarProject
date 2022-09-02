using Microsoft.EntityFrameworkCore;
using RentACarProject.Models;
using System;

namespace RentACarProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Color> Colors { get; set; }


        #region Data Seeding
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Brand

            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Mercedes",
                    ImageUrl="mercedes.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 2,
                    Name = "Hyundai",
                    ImageUrl = "hyundai.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 3,
                    Name = "Toyota",
                    ImageUrl = "toyota.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 4,
                    Name = "BMW",
                    ImageUrl = "bmw.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 5,
                    Name = "Nissan",
                    ImageUrl = "nissan.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 6,
                    Name = "Mitsubishi",
                    ImageUrl = "mitsubishi.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 7,
                    Name = "Kia",
                    ImageUrl = "kia.png",
                    CreatedAt = DateTime.Now
                });



            #endregion
        }
        #endregion

    }
}
