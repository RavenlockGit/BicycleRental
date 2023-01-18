using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Shared.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        [Required]
        public int BicycleId { get; set; }
        //public Bicycle Bicycle { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
