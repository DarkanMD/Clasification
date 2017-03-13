using Clasification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class MyRepository: IProductRepository
    {
        private readonly List <Product> products = new List<Product>();

        public MyRepository()
        {

        }


        public void AddProducts()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveItem()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateItem()
        {
            throw new System.NotImplementedException();
        }

        public void AddUser()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new System.NotImplementedException();
        }

        public void GetItems()
        {
            throw new System.NotImplementedException();
        }

        public void GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public void GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}