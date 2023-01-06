using BicycleRental.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Server
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Bicycle> Bicycle { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}
