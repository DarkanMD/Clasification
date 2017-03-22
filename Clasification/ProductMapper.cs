using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class ProductMapper
    {
            private int _productID;
            private decimal _productPrice;
            private int _stock;
            private string _productName = "";
            private string _productType = "";
            private bool _visible = false;
            public ProductMapper()
            {

            }
            public ProductMapper(int id, decimal price, int stock, string name, string type, bool visible)
            {
                _productID = id;
                _productPrice = price;
                _stock = stock;
                _productName = name;
                _productType = type;
                _visible = visible;

            }
            public ProductMapper(int id, string name, decimal price, string type)
            {
                _productID = id;
                _productName = name;
                _productPrice = price;
                _productType = type;


            }
            public string ProductName
            {
                get
                {
                    return _productName;
                }
                set
                {
                    _productName = value;
                }

            }

            public int ProductID
            {
                get
                {
                    return _productID;
                }
                set
                {
                    _productID = value;
                }
            }

            public decimal ProductPrice
            {
                get
                {
                    return _productPrice;
                }
                set
                {
                    _productPrice = value;
                }
            }

            public int Stock
            {
                get
                {
                    return _stock;
                }
                set
                {
                    _stock = value;
                }
            }

            public string ProductType
            {
                get
                {
                    return _productType;
                }
                set
                {
                    _productType = value;
                }

            }
        }
}
