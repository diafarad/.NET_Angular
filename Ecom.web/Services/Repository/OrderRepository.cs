using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class OrderRepository : IOrder
    {
        private ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(c=>c.Id == id);
            if(order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
        }
    }
}

