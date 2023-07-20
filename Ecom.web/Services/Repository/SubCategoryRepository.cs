using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class SubCategoryRepository : ISubCategory
    {
        private ApplicationDbContext _context;

        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(c=>c.Id == id);
            if(subcategory != null)
            {
                _context.SubCategories.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _context.SubCategories;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subcategory != null)
            {
                return subcategory;
            }
            return null;
        }

        public void Insert(SubCategory subcategory)
        {
            _context.SubCategories.Add(subcategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subcategory)
        {
            _context.SubCategories.Update(subcategory);
        }
    }
}

