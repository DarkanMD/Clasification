using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class ProductFactory : IFactory<Product>
    {
        public ProductFactory()
        {

        }

        public Product Create(string data)
        {
            var datasplit = data.Split(';');
            return new Product(Guid.Parse(datasplit[1]),datasplit[2],datasplit[3],datasplit[4],decimal.Parse(datasplit[5]),int.Parse(datasplit[6]),bool.Parse(datasplit[7]));

        }
    }
}
