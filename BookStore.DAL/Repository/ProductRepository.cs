using BookStore.DAL.Data;
using BookStore.DAL.Repository.IRepository;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db) 
		{
			_db = db;
		}
		public void Update(Product obj)
		{
			_db.Products.Update(obj);
		}
	}
}
