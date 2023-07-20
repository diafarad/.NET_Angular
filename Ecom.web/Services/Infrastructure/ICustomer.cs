using System;
using Ecom.web.models;

namespace Ecom.web.Services.Infrastructure
{
	public interface ICustomer
	{
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomer(int id);

        void Insert(Customer customer);

        void Update(Customer customer);

        void Delete(int id);

        int Count();

        void Save();
    }
}

