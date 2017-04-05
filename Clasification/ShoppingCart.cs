using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class ShoppingCart
    {
        List<ICartProduct> _cartProducts = new List<ICartProduct>();
        public Guid UserID { get; private set; }

        public void AddToCart(AbstractProduct product, int quantity)
        {
            _cartProducts.Add(CartProductFactory.Create(product, quantity));
        }

        public void RemoveFromCart(ICartProduct cartProduct)
        {
            _cartProducts.Remove(cartProduct);
        }

        public Order Validate()
        {
            return new Order(_cartProducts,UserID,DateTime.Now.AddDays(7));
        }

        public decimal Total()
        {
            return _cartProducts.Sum(x => x.Subtotal);
        }
    }
}
