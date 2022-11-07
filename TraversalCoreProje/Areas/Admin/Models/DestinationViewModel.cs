using EntityLayer.Concrete;
using System.Collections.Generic;

namespace TraversalCoreProje.Areas.Admin.Models
{
    public class DestinationViewModel
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }
        public bool Status { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Reservation> Reservations { get; set; }
        public string EncryptedId { get; set; }
    }
}
