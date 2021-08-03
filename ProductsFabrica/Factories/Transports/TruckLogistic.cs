using LogisticsFactory.Entities;
using LogisticsFactory.Interfaces;
using System;

namespace LogisticsFactory.Factories
{
	public class TruckLogistic : LogisticFactory
	{
		public override ITransport Create()
		{
			return new Truck();
		}
	}
}
