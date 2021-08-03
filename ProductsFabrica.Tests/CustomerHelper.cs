using LogisticsFactory.Entities.Users;

namespace LogisticsFactory.Tests
{
	public static class CustomerHelper
    {
        public static Customer CreateCorrectCustomer()
		{
            return new() {
                Id = 1,
                Address = "Tole-bi",
                City = "Almaty",
                FirstName = "Bob",
                LastName = "Bobby"
            };
		}
    }
}
