namespace RentACarProject.Entity
{
    public class CarImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        


        #region CarImageCarRelation
        public int CarId { get; set; }
        public Car Car { get; set; }
        #endregion

    }
}
