using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class Product
    {
        private int _productID;
        private string _productDescription="";
        private string _productImageFileName="";
        private decimal _productPrice;
        private string _productName="";
        private string _productType="";

        public Product()
        {

                
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

        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }

            set
            {
                _productDescription = value;
            }
        }

        public string ProductImageFileName
        {
            get
            {
                return _productImageFileName;
            }

            set
            {
                _productImageFileName = value;
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

        public void Display()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return "Name= " + ProductName + " ID = " + ProductID;
        }
    }
}