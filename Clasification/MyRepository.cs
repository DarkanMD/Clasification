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
            return _products.FirstOrDefault(x => x.ProductID == id);
        }

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(x => x.UserID == id);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public void RemoveProduct(int id)
        {
            _products = _products.Where(x => x.ProductID != id).ToList();
        }

        public void RemoveUser(int id)
        {
            _users = _users.Where(x => x.UserID != id).ToList();
        }
    }
}