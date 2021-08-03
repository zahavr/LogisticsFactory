using LogisticsFactory.Entities.Users;
using LogisticsFactory.Interfaces;
using System.Collections.Generic;

namespace LogisticsFactory
{
	public class CustomerController
    {
		private readonly IFakeCustomerRepository _fakeRepository;

		public CustomerController(IFakeCustomerRepository fakeRepository)
		{
			_fakeRepository = fakeRepository;
		}

		public Customer GetCustomer(int id)
		{
			return _fakeRepository.GetById(id);
		}

		public IReadOnlyList<Customer> GetAllCustomers()
		{
			return _fakeRepository.GetAll();
		}

		public bool DeleteCustomer(int id)
		{
			return _fakeRepository.DeleteById(id);
		}

		public bool AddCustomer(Customer customer)
		{
			return _fakeRepository.Add(customer);
		}
    }
}
