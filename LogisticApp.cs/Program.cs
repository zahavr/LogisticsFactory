using LogisticsFactory;
using LogisticsFactory.Entities;
using System;

namespace LogisticApp.cs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, please fill out your destanation:");
			string destenation = Console.ReadLine();

			WriteDeliveryMethod();
			var deliveryMethod = SelectDeliveryMethod(Console.ReadLine());

			Delivery delivery = new Delivery(deliveryMethod, destenation);

			new PurchaseAggregator().CreateDelivery(delivery);
		}

		private static TypeDelivery SelectDeliveryMethod(string deliveryMethod)
		{
			return (TypeDelivery)Enum.Parse(typeof(TypeDelivery), deliveryMethod);
		}

		private static void WriteDeliveryMethod()
		{
			Console.WriteLine("Select delivery method:");

			foreach (var item in Enum.GetValues(typeof(TypeDelivery)))
			{
				Console.WriteLine(item);
			}
		}
	}
}
