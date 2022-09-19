using RentACarProject.Dtos.CarDtos;
using System;
using System.Collections.Generic;

namespace RentACarProject.Dtos.RentalDtos
{
    public class RentalReturnDto
    {
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentalUserDto User { get; set; }
        public RentalCarDto Car { get; set; }
    }

    public class RentalUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class RentalCarDto
    {
        public string Name { get; set; }
        public RentalBrandDto Brand { get; set; }
    }

    public class RentalBrandDto
    {
        public string Name { get; set; }
    }
}
