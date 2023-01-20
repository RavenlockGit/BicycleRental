using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental.Shared.Models
{
    public class BicycleFilter
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(60);

        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public BikeType BikeType { get; set; }

    }
}
