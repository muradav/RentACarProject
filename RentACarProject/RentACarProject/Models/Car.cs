﻿using System.Collections.Generic;

namespace RentACarProject.Models
{
    public class Car:BaseEntity
    {
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }


        #region BrandCarRelation
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        #endregion

        #region CarImageCarRelation
        public List<CarImage> CarImages { get; set; }
        #endregion

        #region CarColorRelation
        public int ColorId { get; set; }
        public Color Color { get; set; }
        #endregion



    }
}
