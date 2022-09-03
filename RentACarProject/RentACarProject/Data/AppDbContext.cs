using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarProject.Models;
using System;

namespace RentACarProject.Data
{
    public class AppDbContext: IdentityDbContext<User>
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
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 8,
                    Name = "Chevrolet",
                    ImageUrl = "chevrolet.png",
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 9,
                    Name = "Lexus",
                    ImageUrl = "lexus.png",
                    CreatedAt = DateTime.Now
                });



            #endregion

            #region Color

            builder.Entity<Color>().HasData(
                new Color
                {
                    Id = 1,
                    Name = "black"
                });
            builder.Entity<Color>().HasData(
                new Color
                {
                    Id = 2,
                    Name = "white"
                });
            builder.Entity<Color>().HasData(
                new Color
                {
                    Id = 3,
                    Name = "brown"
                });
            builder.Entity<Color>().HasData(
                new Color
                {
                    Id = 4,
                    Name = "grey"
                });

            #endregion

            #region Car

            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Name="BMW M5",
                    ModelYear = 2012,
                    DailyPrice = 250,
                    FuelType="Petrol",
                    TransmissionType="Auto",
                    PassengerCount=5,
                    BrandId=4,
                    ColorId=2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 2,
                    Name = "BMW X5",
                    ModelYear = 2011,
                    DailyPrice = 200,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 4,
                    ColorId = 3,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 3,
                    Name = "Chevrolet Aveo",
                    ModelYear = 2013,
                    DailyPrice = 50,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 8,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 4,
                    Name = "Hyundai Accent",
                    ModelYear = 2014,
                    DailyPrice = 50,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 5,
                    Name = "Hyundai Azera",
                    ModelYear = 2013,
                    DailyPrice = 85,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 6,
                    Name = "Hyundai Elantra",
                    ModelYear = 2015,
                    DailyPrice = 55,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 4,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 7,
                    Name = "Hyundai H1",
                    ModelYear = 2014,
                    DailyPrice = 140,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 9,
                    BrandId = 2,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 8,
                    Name = "Hyundai Ix35",
                    ModelYear = 2014,
                    DailyPrice = 65,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 4,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 9,
                    Name = "Hyundai Sonata",
                    ModelYear = 2013,
                    DailyPrice = 70,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 4,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 10,
                    Name = "Hyundai Sonata",
                    ModelYear = 2017,
                    DailyPrice = 75,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 2,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 11,
                    Name = "Kia Cerato",
                    ModelYear = 2014,
                    DailyPrice = 55,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 7,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 12,
                    Name = "Kia Optima",
                    ModelYear = 2014,
                    DailyPrice = 75,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 7,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 13,
                    Name = "Kia Rio",
                    ModelYear = 2014,
                    DailyPrice = 50,
                    FuelType = "Diesel",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 7,
                    ColorId = 4,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 14,
                    Name = "Kia Sorento",
                    ModelYear = 2013,
                    DailyPrice = 90,
                    FuelType = "Diesel",
                    TransmissionType = "Auto",
                    PassengerCount = 7,
                    BrandId = 7,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 15,
                    Name = "Kia Sportage",
                    ModelYear = 2014,
                    DailyPrice = 65,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 7,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 16,
                    Name = "Lexus 570",
                    ModelYear = 2012,
                    DailyPrice = 200,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 7,
                    BrandId = 9,
                    ColorId = 1,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 17,
                    Name = "Mercedes G-class",
                    ModelYear = 2012,
                    DailyPrice = 350,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 1,
                    ColorId = 1,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 18,
                    Name = "Mercedes G-class",
                    ModelYear = 2015,
                    DailyPrice = 400,
                    FuelType = "Petrol",
                    TransmissionType = "Auto",
                    PassengerCount = 5,
                    BrandId = 1,
                    ColorId = 2,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 19,
                    Name = "Mercedes S-class",
                    ModelYear = 2016,
                    DailyPrice = 350,
                    FuelType = "Diesel",
                    TransmissionType = "Auto",
                    PassengerCount = 4,
                    BrandId = 1,
                    ColorId = 1,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
                new Car
                {
                    Id = 20,
                    Name = "Mercedes V-class",
                    ModelYear = 2016,
                    DailyPrice = 450,
                    FuelType = "Diesel",
                    TransmissionType = "Auto",
                    PassengerCount = 6,
                    BrandId = 1,
                    ColorId = 1,
                    CreatedAt = DateTime.Now
                });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 21,
                   Name = "Mitsubishi L200",
                   ModelYear = 2013,
                   DailyPrice = 80,
                   FuelType = "Diesel",
                   TransmissionType = "Manual",
                   PassengerCount = 5,
                   BrandId = 6,
                   ColorId = 1,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 22,
                   Name = "Mitsubishi Pajero",
                   ModelYear = 2013,
                   DailyPrice = 85,
                   FuelType = "Petrol",
                   TransmissionType = "Auto",
                   PassengerCount = 7,
                   BrandId = 6,
                   ColorId = 2,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 23,
                   Name = "Nissan Navara",
                   ModelYear = 2013,
                   DailyPrice = 90,
                   FuelType = "Diesel",
                   TransmissionType = "Manual",
                   PassengerCount = 5,
                   BrandId = 5,
                   ColorId = 2,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 24,
                   Name = "Nissan Sunny",
                   ModelYear = 2014,
                   DailyPrice = 50,
                   FuelType = "Petrol",
                   TransmissionType = "Manual",
                   PassengerCount = 5,
                   BrandId = 5,
                   ColorId = 4,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 25,
                   Name = "Toyota Camry",
                   ModelYear = 2013,
                   DailyPrice = 90,
                   FuelType = "Petrol",
                   TransmissionType = "Auto",
                   PassengerCount = 5,
                   BrandId = 3,
                   ColorId = 4,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 26,
                   Name = "Toyota Land Cruiser",
                   ModelYear = 2014,
                   DailyPrice = 160,
                   FuelType = "Petrol",
                   TransmissionType = "Auto",
                   PassengerCount = 7,
                   BrandId = 3,
                   ColorId = 2,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 27,
                   Name = "Toyota Land Cruiser",
                   ModelYear = 2018,
                   DailyPrice = 300,
                   FuelType = "Petrol",
                   TransmissionType = "Auto",
                   PassengerCount = 7,
                   BrandId = 3,
                   ColorId = 4,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 28,
                   Name = "Toyota Prado",
                   ModelYear = 2015,
                   DailyPrice = 120,
                   FuelType = "Diesel",
                   TransmissionType = "Auto",
                   PassengerCount = 7,
                   BrandId = 3,
                   ColorId = 2,
                   CreatedAt = DateTime.Now
               });
            builder.Entity<Car>().HasData(
               new Car
               {
                   Id = 29,
                   Name = "Toyota Prado",
                   ModelYear = 2018,
                   DailyPrice = 200,
                   FuelType = "Petrol",
                   TransmissionType = "Auto",
                   PassengerCount = 7,
                   BrandId = 3,
                   ColorId = 2,
                   CreatedAt = DateTime.Now
               });

            #endregion

            #region CarImage

            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 1,
                    ImageUrl = "bmw-m5.jpg",
                    CarId=1
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 2,
                    ImageUrl = "bmw-x5.jpg",
                    CarId = 2
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 3,
                    ImageUrl = "chevrolet-aveo-2013.jpg",
                    CarId = 3
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 4,
                    ImageUrl = "hyundai-accent-2014.jpg",
                    CarId = 4
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 5,
                    ImageUrl = "hyundai - azera - 2013.jpg",
                    CarId = 5
                }); 
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 6,
                    ImageUrl = "hyundai - elantra - 2015.jpg",
                    CarId = 6
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 7,
                    ImageUrl = "hyundai-h1-2014.jpg",
                    CarId = 7
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 8,
                    ImageUrl = "hyundai-ix35-2014.jpg",
                    CarId = 8
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 9,
                    ImageUrl = "hyundai-sonata-2013.jpg",
                    CarId = 9
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 10,
                    ImageUrl = "hyundai-sonata-2017.jpg",
                    CarId = 10
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 11,
                    ImageUrl = "kia-cerato-2014.jpg",
                    CarId = 11
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 12,
                    ImageUrl = "kia-optima-2014.jpg",
                    CarId = 12
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 13,
                    ImageUrl = "kia-rio-2014.jpg",
                    CarId = 13
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 14,
                    ImageUrl = "kia-sorento-2013.jpg",
                    CarId = 14
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 15,
                    ImageUrl = "kia-sportage-2014.jpg",
                    CarId = 15
                });
            builder.Entity<CarImage>().HasData(
                new CarImage
                {
                    Id = 16,
                    ImageUrl = "lexus-570-2012.jpg",
                    CarId = 16
                });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 17,
                   ImageUrl = "mercedes-g-class-2012.jpg",
                   CarId = 17
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 18,
                   ImageUrl = "mercedes-g-class-2015.jpg",
                   CarId = 18
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 19,
                   ImageUrl = "mercedes-s-class-2016.jpg",
                   CarId = 19
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 20,
                   ImageUrl = "mercedes-v-class-2016.jpg",
                   CarId = 20
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 21,
                   ImageUrl = "mitsubishi-L200-2013.jpg",
                   CarId = 21
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 22,
                   ImageUrl = "mitsubishi-pajero.jpg",
                   CarId = 22
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 23,
                   ImageUrl = "nissan-navara-2013.jpg",
                   CarId = 23
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 24,
                   ImageUrl = "nissan-sunny-2014.jpg",
                   CarId = 24
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 25,
                   ImageUrl = "toyota-camry-2013.jpg",
                   CarId = 25
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 26,
                   ImageUrl = "toyota-land-cruiser-2014.jpg",
                   CarId = 26
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 27,
                   ImageUrl = "toyota-land-cruiser-2018.jpg",
                   CarId = 27
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 28,
                   ImageUrl = "toyota-prado-2015.jpg",
                   CarId = 28
               });
            builder.Entity<CarImage>().HasData(
               new CarImage
               {
                   Id = 29,
                   ImageUrl = "toyota-prado-2018.jpg",
                   CarId = 29
               });


            #endregion
        }
        #endregion

    }
}
