using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    public class Brand:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [NotMappedAttribute]
        public IFormFile Image { get; set; }

        #region BrandCarRelation
        public List<Car> Cars { get; set; }
        #endregion

    }
}
