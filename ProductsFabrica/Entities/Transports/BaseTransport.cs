using LogisticsFactory.Interfaces;
using System;

namespace LogisticsFactory.Entities
{
	public abstract class BaseTransport : ITransport
    {
        public decimal Price { get; protected set; }

		public abstract decimal CalculatePrice();

		public abstract string Deliver(string destination);

	}
}
