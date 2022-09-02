using System.Collections.Generic;

namespace RentACarProject.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }


        #region CarColorRelation
        public List<Car> Cars { get; set; }
        #endregion
    }
}
