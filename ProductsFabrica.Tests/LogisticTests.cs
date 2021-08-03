using LogisticsFactory.Factories;
using LogisticsFactory.Interfaces;
using Moq;
using Xunit;
using static Xunit.Assert;

namespace LogisticsFactory.Tests
{
	public class LogisticTests
    {
        private const decimal _truckDeliveryPrice = 50;
        private const decimal _shipDeliveryPrice = 100;
        private ITransport truck = new TruckLogistic().Create();
        private ITransport ship = new ShipLogistic().Create();

        [Fact]
        public void CreateTruckWithDefaultDeliveryCost()
		{
            Equal(_truckDeliveryPrice, truck.Price);
		}

        [Fact]
        public void CreateShipWithDefaultDeliveryCost()
        {
            Equal(_shipDeliveryPrice, ship.Price);
        }

        [Fact]
		public void CheckDestinationByShip()
		{
            var dest = "Almaty";

            var result = ship.Deliver(dest);

            Equal($"Your point of destination is {dest}. Ship method is sea.", result);
        }

        [Fact]
        public void CheckDestinationByTruck()
        {
            var dest = "Almaty";

            var result = truck.Deliver(dest);

            Equal($"Your point of destination is {dest}. Ship method is land.", result);
        }

        [Fact]
		public void CalculatePriceForShip()
		{
            var result = ship.CalculatePrice();

            Equal(10000, result);
		}

        [Fact]
        public void CalculatePriceForTruck()
        {
            var result = truck.CalculatePrice();

            Equal(2500, result);
        }
    }
}
 