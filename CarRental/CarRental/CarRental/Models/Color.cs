using System.Collections.Generic;

namespace RentACarProject.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }


        #region CarColorRelation
        public List<Car> Cars { get; set; }
        #endregion
    }
}
