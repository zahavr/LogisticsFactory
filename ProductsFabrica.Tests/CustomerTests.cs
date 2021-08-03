using LogisticsFactory.Entities.Users;
using LogisticsFactory.Interfaces;
using Moq;
using Xunit;
using static Xunit.Assert;

namespace LogisticsFactory.Tests
{
	public class CustomerTests
    {
		private Mock<IFakeCustomerRepository> _repositoryMock = new Mock<IFakeCustomerRepository>();
		private Customer customer = CustomerHelper.CreateCorrectCustomer();

		[Fact]
		public void AddNewCustomer_WithCorrectData_ReturnTrue()
		{
			 _repositoryMock.Setup(x => x.Add(customer)).Returns(true);

			var repository = new CustomerController(_repositoryMock.Object);

			var result = repository.AddCustomer(customer);

			_repositoryMock.Verify(x => x.Add(customer), Times.Once());

			True(result);
		}

		[Fact]
		public void AddNewCustomer_WhenCustomerIsNull_ReturnFalse()
		{
			_repositoryMock.Setup(x => x.Add(null)).Returns(false);

			var repository = new CustomerController(_repositoryMock.Object);

			var result = repository.AddCustomer(customer);

			_repositoryMock.Verify(x => x.Add(customer), Times.Once());

			False(result);
		}

		[Fact]
		public void GetAllCustomers()
		{
			var repository = new CustomerController(_repositoryMock.Object);

			var result = repository.GetAllCustomers();

			_repositoryMock.Verify(x => x.GetAll(), Times.Once());
		}

		[Fact]
		public void GetCustomerById_WhenCustomerIdIsExist()
		{
			var customerId = 1;
			_repositoryMock.Setup(x => x.GetById(customerId)).Returns(customer);

			var repository = new CustomerController(_repositoryMock.Object);

			var result = repository.GetCustomer(customerId);

			_repositoryMock.Verify(x => x.GetById(customerId), Times.Once());

			Equal(customer.Id, result.Id);
		}

		[Fact]
		public void GetCustomerById_WhenCustomerIdIsNotExist()
		{
			var customerId = 2;
			_repositoryMock.Setup(x => x.GetById(customerId));

			var repository = new CustomerController(_repositoryMock.Object);

			var result = repository.GetCustomer(customerId);

			_repositoryMock.Verify(x => x.GetById(customerId), Times.Once());

			NotEqual(customer.Id, result?.Id);
		}

		[Fact]
		public void DeleteCustomer_WhenCustomerIdIsExist()
		{
			var customerId = 1;
			_repositoryMock.Setup(x => x.DeleteById(customerId)).Returns(true);

			var repository = new CustomerController(_repositoryMock.Object);
			var result = repository.DeleteCustomer(customerId);

			_repositoryMock.Verify(x => x.DeleteById(customerId), Times.Once());

			True(result);
		}

		[Fact]
		public void DeleteCustomer_WhenCustomerIdIsNotExist()
		{
			var customerId = 2;
			_repositoryMock.Setup(x => x.DeleteById(customerId)).Returns(false);

			var repository = new CustomerController(_repositoryMock.Object);
			var result = repository.DeleteCustomer(customerId);

			_repositoryMock.Verify(x => x.DeleteById(customerId), Times.Once());

			False(result);
		}
	}
}
