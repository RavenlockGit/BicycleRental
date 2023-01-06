namespace BicycleRental.Shared.Models
{
    public class Reservation
    {
        public int UserId { get; set; }
        public int BicycleId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
