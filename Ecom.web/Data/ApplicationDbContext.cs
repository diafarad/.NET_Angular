using System;
using Ecom.web.models;
using Microsoft.EntityFrameworkCore;

namespace Ecom.web.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{

		}

		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Orderline> Orderlines { get; set; }
		public DbSet<Picture> Pictures { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }


    }
}

