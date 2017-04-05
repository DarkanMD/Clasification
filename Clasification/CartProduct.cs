using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class CartProduct : ICartProduct
    {
        public CartProduct(AbstractProduct prod, int quantity)
        {
            Product = prod;
            Quantity = quantity;
            Subtotal = quantity * Product.ProductPrice;
           
        }

        public int Quantity { get; private set; }

        public AbstractProduct Product { get;  set; }

        public decimal Subtotal { get; private set; }


        public override string ToString()
        {
            return $"{Product.ProductName}     {Quantity} pice(s)";
        }
    }
}