using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class OrderLineRepository : IOrderLine
    {
        private ApplicationDbContext _context;

        public OrderLineRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Orderlines.Count();
        }

        public void Delete(int id)
        {
            var orderLine = _context.Orderlines.FirstOrDefault(c=>c.Id == id);
            if(orderLine != null)
            {
                _context.Orderlines.Remove(orderLine);
            }
        }

        public IEnumerable<Orderline> GetOrderlines()
        {
            return _context.Orderlines;
        }

        public Orderline GetOrderline(int id)
        {
            var orderLine = _context.Orderlines.FirstOrDefault(c => c.Id == id);
            if (orderLine != null)
            {
                return orderLine;
            }
            return null;
        }

        public void Insert(Orderline orderLine)
        {
            _context.Orderlines.Add(orderLine);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Orderline orderline)
        {
            _context.Orderlines.Update(orderline);
        }

        
    }
}

