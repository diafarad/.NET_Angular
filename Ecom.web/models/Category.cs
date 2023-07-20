using System;
namespace Ecom.web.models
{
	public class Category
	{
        public int IdCategory { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public virtual ICollection<SubCategory> SubCategories { get; set; } = new HashSet<SubCategory>();
    }
}

