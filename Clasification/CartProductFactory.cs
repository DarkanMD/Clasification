using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class CartProductFactory
    {

        public static CartProduct Create(AbstractProduct product, int quantity)
        {
            return new CartProduct(product, quantity);
        }
    }
}
