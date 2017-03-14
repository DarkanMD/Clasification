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

        public List<Product> Search(string parameter)
        {
            return _products.Where(x => x.ProductName.Contains(parameter)).ToList();
        }

        public void Add(Product p)
        {
            _products.Add(p);
        }

        public Product Get(int id)
        {
            foreach (var item in _products)
            {
                if (item.ProductID == id)
                {
                    return item;
                }
            }
            throw new Exception("Item not found");
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Remove(int id)
        {
            _products = _products.Where(x => x.ProductID != id).ToList();
        }
    }
}