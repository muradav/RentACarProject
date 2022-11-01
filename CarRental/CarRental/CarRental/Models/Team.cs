using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        [NotMappedAttribute]
        public IFormFile Image { get; set; }
    }
}
