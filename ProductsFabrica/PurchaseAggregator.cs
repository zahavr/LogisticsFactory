using LogisticsFactory.Entities;
using LogisticsFactory.Factories;
using LogisticsFactory.Interfaces;
using System;

namespace LogisticsFactory
{
	public class PurchaseAggregator
	{
		/// <summary>
		/// User choice type delivery
		/// </summary>
		/// <param name="typeDelivery"></param>
		public void CreateDelivery(Delivery delivery)
		{
			ITransport transport = CreateTransport(delivery.TypeDelivery);

			string deliveryText = transport.Deliver(delivery.Destination);

			Console.WriteLine(deliveryText);
		}

		private ITransport CreateTransport(TypeDelivery typeDelivery) => typeDelivery
			switch
		{
			TypeDelivery.Truck => new TruckLogistic().Create(),
			TypeDelivery.Ship => new ShipLogistic().Create(),
			_ => throw new ArgumentException($"Incorrect {nameof(typeDelivery)}")
		};
	}
}
