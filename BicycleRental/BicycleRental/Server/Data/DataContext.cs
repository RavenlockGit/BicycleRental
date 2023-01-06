using BicycleRental.Server.Data.Seeders;
using BicycleRental.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Bicycle> Bicycle { get; set; }
        public DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Amount of entities to be created by seeders.
            const int entityAmount = 5;

            ////Configurations
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());

            //Seeders
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bicycle>().HasData(new BicycleSeeder().Generate(entityAmount));
            modelBuilder.Entity<Reservation>().HasData(new ReservationSeeder().Generate(entityAmount));
        }
    }
}
