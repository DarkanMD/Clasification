using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class Product
    {
        private int _productID;
        private decimal _productPrice;
        private int _stock;
        private string _productName="";
        private string _productType="";
        private bool _visible = false;

        public Product(int id, string name, decimal price, string type)
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

        public override string ToString()
        {
            return "ProductName = " + ProductName + ", ID = " + ProductID;
        }
    }
}