namespace BicycleRental.Server.Data.Seeders
{
    /// <summary>
    /// DB Seeder
    /// </summary>
    /// <typeparam name="T">Specific Model</typeparam>
    public interface ISeeder<T>
    {
        /// <summary>
        /// Generates a list of randomized objects.
        /// Uses Bogus Faker to create objects.
        /// </summary>
        /// <param name="maxAmount">Amount of objects to be created</param>
        /// <returns>List of randomized objects</returns>
        public List<T> Generate(int maxAmount);
    }
}
