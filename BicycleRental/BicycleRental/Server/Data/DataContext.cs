using BicycleRental.Server.Data.Seeders;
using BicycleRental.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Server.Data
{
    public class DataContext : DbContext
    {

        //Deactivated because its the DbSet fields realy dont have to be null validated....

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
