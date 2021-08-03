namespace LogisticsFactory.Interfaces
{
	public interface ITransport
    {
		public decimal Price { get; }
		public string Deliver(string destination);
		public decimal CalculatePrice();
    }
}
