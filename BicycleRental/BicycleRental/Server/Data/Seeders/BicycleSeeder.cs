using BicycleRental.Shared.Models;
using Bogus;

namespace BicycleRental.Server.Data.Seeders;

internal class BicycleSeeder : ISeeder<Bicycle>
{
    public BicycleSeeder()
    {
    }

    //Randomly generating bikes using Bogus (obviously)
    //https://github.com/bchavez/Bogus
    public List<Bicycle> Generate(int maxAmount)
    {
        List<Bicycle> bicycleList = new Faker<Bicycle>()
            .RuleFor(bicycles => bicycles.Id, faker => faker.IndexFaker + 1)
            .RuleFor(bicycles => bicycles.Name, faker => faker.Name.FirstName())
            .RuleFor(bicycles => bicycles.Place, faker => faker.Address.City())
            .RuleFor(bicycles => bicycles.Region, faker => faker.Address.County())
            .RuleFor(bicycles => bicycles.Brand, faker => faker.Lorem.Slug())
            .RuleFor(bicycles => bicycles.GearCount, faker => faker.Random.Int(1, 40))
            .RuleFor(bicycles => bicycles.TireSize, faker => faker.Random.Int(10, 30))
            .RuleFor(bicycles => bicycles.PrizePerDay, faker => faker.Random.Double(0, 300))
            .RuleFor(bicycles => bicycles.Type, faker => (BikeType)faker.Random.Int(0, 6))

            .Generate(maxAmount);
        Faker fkr = new Faker();

        foreach (var bike in bicycleList)
        {
            bike.FrontPicture = File.ReadAllBytes($"C:\\Users\\nicol\\Documents\\HF 20I\\ASP\\BicycleRental\\BicycleRental\\BicycleRental\\Server\\Images\\bike{fkr.Random.Int(1, 3)}.jfif");

            bike.Picture2 = File.ReadAllBytes($"C:\\Users\\nicol\\Documents\\HF 20I\\ASP\\BicycleRental\\BicycleRental\\BicycleRental\\Server\\Images\\bike{fkr.Random.Int(1, 3)}.jfif");
            bike.Picture3 = File.ReadAllBytes($"C:\\Users\\nicol\\Documents\\HF 20I\\ASP\\BicycleRental\\BicycleRental\\BicycleRental\\Server\\Images\\bike{fkr.Random.Int(1, 3)}.jfif");
            bike.Picture4 = File.ReadAllBytes($"C:\\Users\\nicol\\Documents\\HF 20I\\ASP\\BicycleRental\\BicycleRental\\BicycleRental\\Server\\Images\\bike{fkr.Random.Int(1, 3)}.jfif");
        }

        return bicycleList;
    }
}