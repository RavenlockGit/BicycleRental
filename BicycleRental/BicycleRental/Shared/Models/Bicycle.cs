using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Shared.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        //For simplicity we dont care if the set place is actually part of the given Region
        [Required]
        public string? Place { get; set; }

        [Required]
        public string? Region { get; set; }
        public string? Brand { get; set; }
        public int GearCount { get; set; }
        public int TireSize { get; set; }

        public double PrizePerDay { get; set; }

        public BikeType Type { get; set; }

        //User can upload max 4 pictures

        [Required]
        public byte[]? FrontPicture { get; set; }
        public byte[]? Picture2 { get; set; }
        public byte[]? Picture3 { get; set; }
        public byte[]? Picture4 { get; set; }

    }

    public enum BikeType
    {
        Unknown,
        Trike,
        ChildBike,
        ElectroBike,
        SportsBike,
        WomensBike,
        StandardBike
    }
}