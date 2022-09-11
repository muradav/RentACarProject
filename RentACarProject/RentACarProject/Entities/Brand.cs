using System.Collections.Generic;

namespace RentACarProject.Entity
{
    public class Brand:BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        #region BrandCarRelation
        public List<Car> Cars { get; set; }
        #endregion

    }
}
