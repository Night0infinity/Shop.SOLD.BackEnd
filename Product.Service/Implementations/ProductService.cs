using Product.Service.Interfaces;
using Shop.Domain.Response;
using Product.Service.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Product.Service.Implementations
{


    public class ProductService : IProductService
    {
        public Task<BaseResponse<IEnumerable<Product>>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }

}
