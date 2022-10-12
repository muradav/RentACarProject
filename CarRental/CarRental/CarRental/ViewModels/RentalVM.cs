using CarRental.Helpers;
using RentACarProject.Models;
using System.Collections.Generic;

namespace CarRental.ViewModels
{
    public class RentalVM
    {
        public List<Car> Cars { get; set; }
        public PagedList<Car> PagedLists { get; set; }
    }
}
