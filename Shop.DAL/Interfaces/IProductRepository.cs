using Shop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Interfaces
{
    internal interface IProductRepository : IBaseRepository<Product>
    {
        Product GetByName(string name); //uses for getting object by name from  products(not users)
    }
}
