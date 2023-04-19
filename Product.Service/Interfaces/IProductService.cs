using System;
using Shop.Domain.Response;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Product.Service.Interfaces
{
    public interface IProductService
    {
        Task<BaseResponse<IEnumerable<Product>>> GetProducts();

    }
}
