using Clasification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class MyRepository
    {
        public List <Product> _products = new List<Product>();
        public List <User> _users = new List<User>();
        public List <Order> _orders = new List<Order>();

        public List<Product> SearchProduct(string parameter)
        {
            return _products.Where(x => x.ProductName.Contains(parameter)).ToList();
        }

        public List<User> SearchUser(string parameter)
        {
            return _users.Where(x => x.UserName.Contains(parameter)).ToList();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public Product GetProduct(int id)
        {
            try
            {
                return _products.Single(x => x.ProductID == id);
            }
           catch(Exception)
            {
                Console.WriteLine("ProductID not unical");
                throw;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                return _users.Single(x => x.UserID == id);
            }
            catch (Exception)
            {
                Console.WriteLine("UserID not unical");
                throw;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public List<Order> GetAllOrders(int id)
        {
            return _orders.Where(x => x.UserID == id).OrderBy(x => x.OrderID).ToList();
        }

        public void RemoveProduct(int id)
        {
            _products = _products.Where(x => x.ProductID != id).ToList();
        }

        public void RemoveUser(int id)
        {
            _users = _users.Where(x => x.UserID != id).ToList();
        }
        public void RemoveOrder(int id)
        {
            _orders = _orders.Where(x => x.OrderID != id).ToList();
        }
    }
}