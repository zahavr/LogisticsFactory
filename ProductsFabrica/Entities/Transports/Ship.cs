using LogisticsFactory.Interfaces;

namespace LogisticsFactory.Entities
{
	public class Ship : BaseTransport
	{
		private const decimal _price = 100;
		public Ship()
		{
			Price = _price;
		}

		public override decimal CalculatePrice()
		{
			return Price * 100;
		}

		public override string Deliver(string destination)
		{
			return $"Your point of destination is {destination}. Ship method is sea.";
		}
		
		
	}
}
