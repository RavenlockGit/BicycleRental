using BicycleRental.Shared.Models;
using Bogus;

namespace BicycleRental.Server.Data.Seeders;

internal class ReservationSeeder : ISeeder<Reservation>
{
    public ReservationSeeder()
    {
    }

    public List<Reservation> Generate(int maxAmount)
    {

        List<Reservation> reservationList = new Faker<Reservation>()
            .RuleFor(reservation => reservation.Id, faker => faker.IndexFaker + 1)
            .RuleFor(reservation => reservation.BicycleId, faker => faker.Random.Int(0, maxAmount)+1)

            .RuleFor(reservation => reservation.StartDate, faker => faker.Date.Between(DateTime.Now, DateTime.Now.AddDays(10)))
            .RuleFor(reservation => reservation.EndDate, faker => faker.Date.Between(DateTime.Now.AddDays(11), DateTime.Now.AddDays(20)))
            .Generate(maxAmount);
        return reservationList;

    }
}