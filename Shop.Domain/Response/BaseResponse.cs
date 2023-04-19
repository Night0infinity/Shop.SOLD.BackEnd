using Shop.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.Response;
using Shop.Domain.Enum;

namespace Shop.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; } // Throw name of error

        public Enum.StatusCode StatusCode { get; set; } //number of error

        public object Data { get; set; }

        T IBaseResponse<T>.Data => throw new NotImplementedException();
    }

    public interface IBaseResponse<T> {

        T Data { get; }
    }
}
