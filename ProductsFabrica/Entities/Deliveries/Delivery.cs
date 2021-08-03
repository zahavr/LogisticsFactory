namespace LogisticsFactory.Entities
{
	public class Delivery
    {
		public Delivery(TypeDelivery typeDelivery, string destination)
		{
			TypeDelivery = typeDelivery;
			Destination = destination;
		}	

		public TypeDelivery TypeDelivery { get; private set; }
		public string Destination { get; private set; }
	}
}
