using Clasification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Clasification
{
    public class MyRepository
    {
        public List <Product> _products = new List<Product>();
        public List <User> _users = new List<User>();
        public List <Order> _orders = new List<Order>();

        TXTReaderWriter txtHandler = new TXTReaderWriter();
        Serializer json = new Serializer();

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

        public Product GetProduct(Guid id)
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

        public User GetUser(Guid id)
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
            return json.DeserializeProducts(txtHandler.Read("_products"));
        }

        public List<User> GetAllUsers()
        {
            return json.DeserializeUsers(txtHandler.Read("_users"));
        }

        public List<Order> GetAllOrders(int id)
        {
            return json.DeserializeOrders(txtHandler.Read("_orders"));
        }

        public void RemoveProduct(Guid id)
        {
            _products = _products.Where(x => x.ProductID != id).ToList();
        }

        public void RemoveUser(Guid id)
        {
            _users = _users.Where(x => x.UserID != id).ToList();
        }
        public void RemoveOrder(Guid id)
        {
            _orders = _orders.Where(x => x.OrderID != id).ToList();
        }

        public void Save()
        {
            txtHandler.Write("_products",json.Serialize(_products));

            txtHandler.Write("_users",json.Serialize(_users));

            txtHandler.Write("_orders",json.Serialize(_orders));
        }
    }
}