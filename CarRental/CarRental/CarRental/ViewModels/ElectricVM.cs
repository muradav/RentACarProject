using CarRental.Helpers;
using CarRental.Models;
using System.Collections.Generic;

namespace CarRental.ViewModels
{
    public class ElectricVM
    {
        public List<Car> Cars { get; set; }
        public PagedList<Car> PagedLists { get; set; }
    }
}
