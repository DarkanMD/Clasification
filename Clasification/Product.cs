using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Clasification
{
   // [DataContract]
    public class Product
    {
       // [DataMember]
        private int _productID;
      //  [DataMember]
        private decimal _productPrice;
      //  [DataMember]
        private int _stock;
      //  [DataMember]
        private string _productName="";
      //  [DataMember]
        private string _productType="";
       // [DataMember]
        private bool _visible = false;
        public Product()
        {

        }
        public Product(int id,decimal price,int stock,string name,string type,bool visible)
        {
            _productID = id;
            _productPrice = price;
            _stock = stock;
            _productName = name;
            _productType = type;
            _visible = visible;

    }
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
        }

        public int ProductID
        {
            get
            {
                return _productID;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return _productPrice;
            }

        }

        public int Stock
        {
            get
            {
                return _stock;
            }
        }

        public string ProductType
        {
            get
            {
                return _productType;
            }


        }

        public override string ToString()
        {
            return "ProductName = " + ProductName + ", ID = " + ProductID;
        }

        public string ToSerial()
        {
            return _productID + "," + _productPrice + "," + _stock + "," + _productName + "," + _productType + "," + _visible;
        }

    }
}