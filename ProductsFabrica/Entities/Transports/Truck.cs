namespace LogisticsFactory.Entities
{
	public class Truck : BaseTransport
	{
		private const decimal _price = 50;
		public Truck()
		{
			Price = _price;
		}

		public override decimal CalculatePrice()
		{
			return Price * 50;
		}

		public override string Deliver(string destination)
		{
			return $"Your point of destination is {destination}. Ship method is land.";
		}
	}
}
