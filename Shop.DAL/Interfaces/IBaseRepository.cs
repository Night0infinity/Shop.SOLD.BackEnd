using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Interfaces
{
    internal interface IBaseRepository<T>  // T = (Product / users) 
    {
        //Iteract with data and get object
        bool Create(T entity); // 

        T Get(int id);

        IEnumerable<T> Select(); //Get collection of elements

        bool Delete(T entity);


    }
}
