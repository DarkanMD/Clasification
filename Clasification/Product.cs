using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading;

namespace Clasification
{
    public class Product
    {
        //private Guid _productID;
        //private decimal _productPrice;
        //private int _stock;
        //private string _productName="";
        //private bool _visible = false;
        //public Product()
        //{

        //}
    //    public Product(int id, decimal price,int stock,string name,bool visible)
    //    {
    //        _productID = id;
    //        _productPrice = price;
    //        _stock = stock;
    //        _productName = name;
    //        _visible = visible;

    //}
        public Product(string name, string type, string category, decimal price, int stock,bool visible)
        {
            ProductID = Guid.NewGuid();
            ProductName = name;
            ProductType = type;
            ProductCategory = category;
            ProductPrice = price;
            ProductStock = stock;
            ProductVisible = visible;

        }
        public Product(Guid guid,string name,string type, string category, decimal price, int stock, bool visible)
        {
            ProductID = guid;
            ProductName = name;
            ProductType = type;
            ProductCategory = category;
            ProductPrice = price;
            ProductStock = stock;
            ProductVisible = visible;

        }
        public string ProductName{get; private set;}

        public string ProductType { get; private set; }

        public Guid ProductID{get; private set;}

        public decimal ProductPrice { get; private set; }

        public int ProductStock { get; private set; }

        public bool ProductVisible { get; private set; }

        public string ProductCategory { get; private set; }

        public override string ToString()
        {
            return $"{ProductID};{ProductName};{ProductType};{ProductCategory};{ProductPrice};{ProductStock};{ProductVisible}";
        }

        public string ToDB()
        {
            return ProductID + ";" + ProductName + ";"+ProductType+";" + ProductCategory + ";" + ProductPrice + ";" + ProductStock + ";"+ ProductVisible;
        }

    }
}