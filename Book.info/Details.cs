using System.ComponentModel.DataAnnotations;

namespace Book.info
{
    public class Details
    {
        public int Id { get; set; }

       
        public string Description { get; set; }
        public double Ratings { get; set; }
        public string Editorial { get; set; }
        public string Review { get; set; }
    }
}