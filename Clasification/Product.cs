using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class Product
    {
        private int _productID;
        private string _productDescription;
        private string _productImageFileName;
        private decimal _productPrice;
        private string _productName;
        private string _productType;

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

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}