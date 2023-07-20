using System;
using Ecom.web.models;

namespace Ecom.web.Services.Infrastructure
{
	public interface IOrderLine
	{
		IEnumerable<Orderline> GetOrderlines();

        Orderline GetOrderline(int id);

		void Insert(Orderline orderline);

		void Update(Orderline orderline);

		void Delete(int id);

		int Count();

		void Save();
	}
}

