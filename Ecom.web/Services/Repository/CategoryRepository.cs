using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class CategoryRepository : ICategory
    {
        private ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Categories.Count();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c=>c.IdCategory == id);
            if(category != null)
            {
                _context.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public Category GetCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.IdCategory == id);
            if (category != null)
            {
                return category;
            }
            return null;
        }

        public void Insert(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}

