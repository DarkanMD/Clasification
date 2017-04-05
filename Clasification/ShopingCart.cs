using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class ShopingCart
    {
        private int _cartID;
        private int _userID;
        private List<CartProduct> _cartProducts =new List<CartProduct>();
        private decimal _cartTotal;
        private DateTime _cartCreationDate;

        public List<CartProduct> CartProducts
        {
            get
            {
                return _cartProducts;
            }

        }

        public int CartID
        {
            get
            {
                return _cartID;
            }

            set
            {
                _cartID = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }

        public decimal CartTotal
        {
            get
            {
                return _cartTotal;
            }
            set
            {

            }
        }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void Cancel()
        {
         
        }

        public void Remove(Product product)
        {
            _cartProducts = _cartProducts.Where(x => x.Product != product).ToList();
            _cartTotal = _cartProducts.Select(x => x.Subtotal).Sum();
        }

        public void Add(CartProduct product)
        {
            _cartProducts.Add(product);
            _cartTotal = _cartTotal + product.Subtotal;
        }

        public List<CartProduct> GetAllCartProducts()
        {
            return _cartProducts;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in _cartProducts)
            {
                result += item.Product.ToString() +"\\n";
            }
            return result;
        }
    }
}