using LogisticsFactory.Entities.Users;
using LogisticsFactory.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LogisticsFactory.Repositories
{
	public class FakeCustomerRepository :  IFakeCustomerRepository
	{
		public bool Add(Customer entity)
		{
			if (entity is null)
			{
				return false;
			}

			return true;
		}

		public bool DeleteById(int id)
		{
			List<Customer> customers = new List<Customer>()
			{
				new Customer()
				{
					Id = 1,
					Address = "Address",
					City = "City",
					FirstName = "Flow",
					LastName = "Flower"
				}
			};
			var customer = customers.SingleOrDefault(x => x.Id == id);

			if (customer is null)
			{
				return false;
			}

			return customers.Remove(customer);
		}

		public IReadOnlyList<Customer> GetAll()
		{
			return new List<Customer>()
			{
				new Customer()
				{
					Id = 1,
					Address = "Address",
					City = "City",
					FirstName = "Flow",
					LastName = "Flower"
				},
				new Customer()
				{
					Id = 2,
					Address = "Address",
					City = "City",
					FirstName = "Flow",
					LastName = "Flower"
				}
			}.AsReadOnly();
		}

		public Customer GetById(int id)
		{
			List<Customer> customers = new List<Customer>()
			{
				new Customer()
				{
					Id = 1,
					Address = "Address",
					City = "City",
					FirstName = "Flow",
					LastName = "Flower"
				}
			};

			return customers.SingleOrDefault(x => x.Id == id);
		}
	}
}
