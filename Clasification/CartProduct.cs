using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class CartProduct
    {
        private int _quantity;
        private Product _product;
        private decimal _subtotal;
        public CartProduct(Product prod, int quant)
        {
            _product = prod;
            _quantity = quant;
            _subtotal = quant * _product.ProductPrice;
           
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }

        public Product Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                _subtotal = _quantity * _product.ProductPrice;
            }


        }

        public override string ToString()
        {
            return _product.ToString() + " " + "Quantity = "+Quantity;
        }
    }
}