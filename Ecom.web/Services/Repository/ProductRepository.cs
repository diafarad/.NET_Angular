using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class ProductRepository : IProduct
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Products.Count();
        }

        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p=>p.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}

