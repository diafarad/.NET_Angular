using System;
using Ecom.web.models;

namespace Ecom.web.Services.Infrastructure
{
	public interface ISubCategory
	{
		IEnumerable<SubCategory> GetSubCategories();

        SubCategory GetSubCategory(int id);

		void Insert(SubCategory subcategory);

		void Update(SubCategory subcategory);

		void Delete(int id);

		int Count();

		void Save();
	}
}

