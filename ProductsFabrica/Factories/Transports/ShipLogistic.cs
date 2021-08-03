using LogisticsFactory.Entities;
using LogisticsFactory.Interfaces;

namespace LogisticsFactory.Factories
{
	public class ShipLogistic : LogisticFactory
	{
		public override ITransport Create()
		{
			return new Ship();
		}
	}
}
