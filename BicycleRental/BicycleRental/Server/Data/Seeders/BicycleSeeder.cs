using BicycleRental.Shared.Models;
using Bogus;

namespace BicycleRental.Server.Data.Seeders;

internal class BicycleSeeder: ISeeder<Bicycle>
{
    public BicycleSeeder()
    {
    }

    //Randomly generating bikes using Bogus (obviously)
    public List<Bicycle> Generate(int maxAmount)
    {
        List<Bicycle> bicycleList = new Faker<Bicycle>()
            .RuleFor(bicycles => bicycles.Id, faker => faker.IndexFaker + 1)
            .RuleFor(bicycles => bicycles.Name, faker => faker.Name.FirstName())
            .RuleFor(bicycles => bicycles.Place, faker => faker.Address.City())
            .RuleFor(bicycles => bicycles.Region, faker => faker.Address.County())
            .RuleFor(bicycles => bicycles.Brand, faker => faker.Lorem.Slug())
            .RuleFor(bicycles => bicycles.GearCount, faker => faker.Random.Int())
            .RuleFor(bicycles => bicycles.TireSize, faker => faker.Random.Int(10, 30))
            .RuleFor(bicycles => bicycles.PrizePerDay, faker => faker.Random.Double(0, 300))
            .RuleFor(bicycles => bicycles.Type, faker => (BikeType)faker.Random.Int(0, 6))
            .Generate(maxAmount);
        return bicycleList;
    }
}