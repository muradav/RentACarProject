﻿using CarRental.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarRental.DAL
{ 
    public class AppDbContext : IdentityDbContext<User>
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            public DbSet<Brand> Brands { get; set; }
            public DbSet<Car> Cars { get; set; }
            public DbSet<CarImage> CarImages { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<Rental> Rentals { get; set; }
            public DbSet<Bio> Bios { get; set; }
            public DbSet<Team> Teams { get; set; }
            public DbSet<About> About { get; set; }



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
                        ImageUrl = "mercedes.png",
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
                builder.Entity<Brand>().HasData(
                    new Brand
                    {
                        Id = 10,
                        Name = "Tesla",
                        ImageUrl = "tesla.png",
                        CreatedAt = DateTime.Now
                    });



            #endregion

            #region Color

            builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 1,
                        Name = "qara"
                    });
                builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 2,
                        Name = "ağ"
                    });
                builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 3,
                        Name = "qəhvəyi"
                    });
                builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 4,
                        Name = "boz"
                    });
                builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 5,
                        Name = "qırmızı"
                    });
                builder.Entity<Color>().HasData(
                    new Color
                    {
                        Id = 6,
                        Name = "mavi"
                    });

            #endregion

            #region Car

            builder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 1,
                        Name = "M5",
                        ModelYear = 2012,
                        DailyPrice = 250,
                        FuelType = "Benzin",
                        TransmissionType = "Auto",
                        PassengerCount = 5,
                        BrandId = 4,
                        ColorId = 2,
                        CreatedAt = DateTime.Now
                    });
                builder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 2,
                        Name = "X5",
                        ModelYear = 2011,
                        DailyPrice = 200,
                        FuelType = "Benzin",
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
                        Name = "Aveo",
                        ModelYear = 2013,
                        DailyPrice = 50,
                        FuelType = "Qaz",
                        TransmissionType = "Manual",
                        PassengerCount = 5,
                        BrandId = 8,
                        ColorId = 2,
                        CreatedAt = DateTime.Now
                    });
                builder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 4,
                        Name = "Accent",
                        ModelYear = 2014,
                        DailyPrice = 50,
                        FuelType = "Dizel",
                        TransmissionType = "Manual",
                        PassengerCount = 5,
                        BrandId = 2,
                        ColorId = 2,
                        CreatedAt = DateTime.Now
                    });
                builder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 5,
                        Name = "Azera",
                        ModelYear = 2013,
                        DailyPrice = 85,
                        FuelType = "Benzin",
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
                        Name = "Elantra",
                        ModelYear = 2015,
                        DailyPrice = 55,
                        FuelType = "Benzin",
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
                        Name = "H1",
                        ModelYear = 2014,
                        DailyPrice = 140,
                        FuelType = "Dizel",
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
                        Name = "Ix35",
                        ModelYear = 2014,
                        DailyPrice = 65,
                        FuelType = "Benzin",
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
                        Name = "Sonata",
                        ModelYear = 2013,
                        DailyPrice = 70,
                        FuelType = "Dizel",
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
                        Name = "Sonata",
                        ModelYear = 2017,
                        DailyPrice = 75,
                        FuelType = "Benzin",
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
                        Name = "Cerato",
                        ModelYear = 2014,
                        DailyPrice = 55,
                        FuelType = "Benzin",
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
                        Name = "Optima",
                        ModelYear = 2014,
                        DailyPrice = 75,
                        FuelType = "Benzin",
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
                        Name = "Rio",
                        ModelYear = 2014,
                        DailyPrice = 50,
                        FuelType = "Dizel",
                        TransmissionType = "Manual",
                        PassengerCount = 5,
                        BrandId = 7,
                        ColorId = 4,
                        CreatedAt = DateTime.Now
                    });
                builder.Entity<Car>().HasData(
                    new Car
                    {
                        Id = 14,
                        Name = "Sorento",
                        ModelYear = 2013,
                        DailyPrice = 90,
                        FuelType = "Dizel",
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
                        Name = "Sportage",
                        ModelYear = 2014,
                        DailyPrice = 65,
                        FuelType = "Dizel",
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
                        Name = "LX570",
                        ModelYear = 2012,
                        DailyPrice = 200,
                        FuelType = "Benzin",
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
                        Name = "G-class",
                        ModelYear = 2012,
                        DailyPrice = 350,
                        FuelType = "Benzin",
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
                        Name = "G-class",
                        ModelYear = 2015,
                        DailyPrice = 400,
                        FuelType = "Benzin",
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
                        Name = "S-class",
                        ModelYear = 2016,
                        DailyPrice = 350,
                        FuelType = "Dizel",
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
                        Name = "V-class",
                        ModelYear = 2016,
                        DailyPrice = 450,
                        FuelType = "Dizel",
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
                       Name = "L200",
                       ModelYear = 2013,
                       DailyPrice = 80,
                       FuelType = "Dizel",
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
                       Name = "Pajero",
                       ModelYear = 2013,
                       DailyPrice = 85,
                       FuelType = "Benzin",
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
                       Name = "Navara",
                       ModelYear = 2013,
                       DailyPrice = 90,
                       FuelType = "Dizel",
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
                       Name = "Sunny",
                       ModelYear = 2014,
                       DailyPrice = 50,
                       FuelType = "Benzin",
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
                       Name = "Camry",
                       ModelYear = 2013,
                       DailyPrice = 90,
                       FuelType = "Benzin",
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
                       Name = "Land Cruiser",
                       ModelYear = 2014,
                       DailyPrice = 160,
                       FuelType = "Benzin",
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
                       Name = "Land Cruiser",
                       ModelYear = 2018,
                       DailyPrice = 300,
                       FuelType = "Benzin",
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
                       Name = "Prado",
                       ModelYear = 2015,
                       DailyPrice = 120,
                       FuelType = "Dizel",
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
                       Name = "Prado",
                       ModelYear = 2018,
                       DailyPrice = 200,
                       FuelType = "Benzin",
                       TransmissionType = "Auto",
                       PassengerCount = 7,
                       BrandId = 3,
                       ColorId = 2,
                       CreatedAt = DateTime.Now
                   });
                builder.Entity<Car>().HasData(
                   new Car
                   {
                       Id = 30,
                       Name = "X",
                       ModelYear = 2016,
                       DailyPrice = 250,
                       FuelType = "Elektrik",
                       TransmissionType = "Auto",
                       PassengerCount = 5,
                       BrandId = 10,
                       ColorId = 2,
                       CreatedAt = DateTime.Now
                   });
                builder.Entity<Car>().HasData(
                   new Car
                   {
                       Id = 31,
                       Name = "S",
                       ModelYear = 2018,
                       DailyPrice = 270,
                       FuelType = "Elektrik",
                       TransmissionType = "Auto",
                       PassengerCount = 4,
                       BrandId = 10,
                       ColorId = 5,
                       CreatedAt = DateTime.Now
                   });
             builder.Entity<Car>().HasData(
                   new Car
                   {
                       Id = 32,
                       Name = "3",
                       ModelYear = 2017,
                       DailyPrice = 250,
                       FuelType = "Elektrik",
                       TransmissionType = "Auto",
                       PassengerCount = 4,
                       BrandId = 10,
                       ColorId = 4,
                       CreatedAt = DateTime.Now
                   });
                builder.Entity<Car>().HasData(
                   new Car
                   {
                       Id = 33,
                       Name = "Leaf",
                       ModelYear = 2017,
                       DailyPrice = 70,
                       FuelType = "Elektrik",
                       TransmissionType = "Auto",
                       PassengerCount = 5,
                       BrandId = 5,
                       ColorId = 6,
                       CreatedAt = DateTime.Now
                   });

            #endregion

            #region CarImage

            builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 1,
                        ImageUrl = "bmw-m5.jpg",
                        CarId = 1,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 2,
                        ImageUrl = "bmw-x5.png",
                        CarId = 2,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 3,
                        ImageUrl = "chevrolet-aveo-2013.jpg",
                        CarId = 3,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 4,
                        ImageUrl = "hyundai-accent-2014.jpg",
                        CarId = 4,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 5,
                        ImageUrl = "hyundai-azera-2013.jpg",
                        CarId = 5,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 6,
                        ImageUrl = "hyundai-elantra-2015.jpg",
                        CarId = 6,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 7,
                        ImageUrl = "hyundai-h1-2014.jpg",
                        CarId = 7,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 8,
                        ImageUrl = "hyundai-ix35-2014.jpg",
                        CarId = 8,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 9,
                        ImageUrl = "hyundai-sonata-2013.jpg",
                        CarId = 9,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 10,
                        ImageUrl = "hyundai-sonata-2017.jpg",
                        CarId = 10,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 11,
                        ImageUrl = "kia-cerato-2014.jpg",
                        CarId = 11,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 12,
                        ImageUrl = "kia-optima-2014.jpg",
                        CarId = 12,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 13,
                        ImageUrl = "kia-rio-2014.jpg",
                        CarId = 13,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 14,
                        ImageUrl = "kia-sorento-2013.jpg",
                        CarId = 14,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 15,
                        ImageUrl = "kia-sportage-2014.jpg",
                        CarId = 15,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                    new CarImage
                    {
                        Id = 16,
                        ImageUrl = "lexus-570-2012.jpg",
                        CarId = 16,
                        IsMain = true
                    });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 17,
                       ImageUrl = "mercedes-g-class-2012.jpg",
                       CarId = 17,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 18,
                       ImageUrl = "mercedes-g-class-2015.jpg",
                       CarId = 18,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 19,
                       ImageUrl = "mercedes-s-class-2016.jpg",
                       CarId = 19,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 20,
                       ImageUrl = "mercedes-v-class-2016.jpg",
                       CarId = 20,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 21,
                       ImageUrl = "mitsubishi-L200-2013.jpg",
                       CarId = 21,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 22,
                       ImageUrl = "mitsubishi-pajero.jpg",
                       CarId = 22,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 23,
                       ImageUrl = "nissan-navara-2013.jpg",
                       CarId = 23,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 24,
                       ImageUrl = "nissan-sunny-2014.jpg",
                       CarId = 24,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 25,
                       ImageUrl = "toyota-camry-2013.jpg",
                       CarId = 25,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 26,
                       ImageUrl = "toyota-land-cruiser-2014.jpg",
                       CarId = 26,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 27,
                       ImageUrl = "toyota-land-cruiser-2018.jpg",
                       CarId = 27,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 28,
                       ImageUrl = "toyota-prado-2015.jpg",
                       CarId = 28,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 29,
                       ImageUrl = "toyota-prado-2018.jpg",
                       CarId = 29,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 30,
                       ImageUrl = "tesla-x-2016.png",
                       CarId = 30,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 31,
                       ImageUrl = "tesla-s-2018.png",
                       CarId = 31,
                       IsMain = true
                   });
                builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 32,
                       ImageUrl = "tesla-3-2017.png",
                       CarId = 32,
                       IsMain = true
                   });
             builder.Entity<CarImage>().HasData(
                   new CarImage
                   {
                       Id = 33,
                       ImageUrl = "nissan-leaf-2017.png",
                       CarId = 33,
                       IsMain = true
                   });


            #endregion

            #region Bio
            builder.Entity<Bio>().HasData(
               new Bio
               {
                   Id = 1,
                   ImageUrl = "logo.png",
                   Location = "Nizami küçəsi 203B, AF Business House, 2-ci mərtəbə, Baku 1000, Azerbaijan",
                   Contact = "+994 55 347 08 80",
                   Email = "hwcarrental@bk.ru",
                   WorkTime = "Bazar ertəsi-Şənbə 9:00pm - 5:00pm Bazar:Bağlıdır",
               });


            #endregion

            #region About
            builder.Entity<About>().HasData(
               new About
               {
                   Id = 1,
                   Title = "BİZ KİMİK",
                   HeaderDesc = "Əziz şəhərimizin qonaqları sizi “HOT WHEEL CAR RENTAL” şirkəti olaraq salamlayırıq.",
                   Desc = "Hot Wheel Car Rental şirkəti yeni yaranmasına baxmayaraq, ölkədə ən böyük avtomobil qarajına sahibdir. Bizim bütün avtomobillərimiz  bütün standartlara cavab verən, ekoloji tələblərə riayət edən yeni avtomobillərdir. Bizim şirkət avtomobil icarəsi bazarına yeni daxil olduğu üçün sərfəli qiymətlərlə digər şirkətləri üstələyir. Kirayə maşın bazarında çox şirkətin olmasına baxmayaraq keyfiyyətli və təhlükəsiz şirkət azlıq təşkil edir.",
                   ImageUrl = "hero_2.jpg",
               });


            #endregion

            #region Team
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 1,
                   Name = "Murad",
                   Surname = "Vəliyev",
                   Position = "CEO",
                   ImageUrl = "murad.jpg"
               });
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 2,
                   Name = "Rəşid",
                   Surname = "Məmməmdov",
                   Position = "CFO",
                   ImageUrl = "rashid.jpg"
               });
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 3,
                   Name = "Fərid",
                   Surname = "Balıyev",
                   Position = "Developer",
                   ImageUrl = "farid.jpg"
               });
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 4,
                   Name = "Umud",
                   Surname = "Umudov",
                   Position = "Mütəxəssis",
                   ImageUrl = "umud.jpg"
               });
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 5,
                   Name = "Samir",
                   Surname = "Əmiraslanov",
                   Position = "Mütəxəssis",
                   ImageUrl = "samir.jpg"
               });
            builder.Entity<Team>().HasData(
               new Team
               {
                   Id = 6,
                   Name = "Orxan",
                   Surname = "Qəhrəmanov",
                   Position = "Mütəxəssis",
                   ImageUrl = "orxan.jpg"
               });


            #endregion
        }
        #endregion

    }
}