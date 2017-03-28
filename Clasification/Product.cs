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
        private int _productID;
        private decimal _productPrice;
        private int _stock;
        private string _productName="";
        private bool _visible = false;
        public Product()
        {

        }
    //    public Product(int id, decimal price,int stock,string name,bool visible)
    //    {
    //        _productID = id;
    //        _productPrice = price;
    //        _stock = stock;
    //        _productName = name;
    //        _visible = visible;

    //}
        public Product(int id,string name, string category, decimal price,int stock,bool visible)
        {
            ProductID = id;
            ProductName = name;
            ProductCategory = category;
            ProductPrice = price;
            Stock = stock;
            Visible = visible;

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

        public string Type { get; set; }/* = ;typeof(this).ToString();*/
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

        public bool Visible { get; set; }


        public string ProductCategory { get; set; }
        public override string ToString()
        {
            return $"ProdcutID: {ProductID} ProductName: {ProductName}, Category: {ProductCategory} Price: {ProductPrice:C} Stock: {Stock} ";
        }

        public string ToSerial()
        {
            return ProductName + "," + ProductCategory + "," + ProductPrice + "," + Stock + "," + Visible;
        }

    }
}