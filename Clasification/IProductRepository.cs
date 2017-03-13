using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    interface IProductRepository:IRepository<Product, string>
    {
            IEnumerable<Product> FindAll();
            IEnumerable<Product> Find(string text);
    }
}
