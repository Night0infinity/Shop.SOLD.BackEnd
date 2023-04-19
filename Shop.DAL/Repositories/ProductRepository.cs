using Microsoft.EntityFrameworkCore;
using Shop.DAL.Interfaces;
using Shop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Repositories
{
    internal class ProductRepository : IProductRepository
    {//------------
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> Select() 
        {
        return _db.Product.ToListAsync(); // async for better loading, less time to load data
        }

        IEnumerable<Product> IBaseRepository<Product>.Select()
        {
            throw new NotImplementedException();
        }
    }
}
