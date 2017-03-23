using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clasification
{
    class Serializer
    {
        public string Serialize(List<Product> inputList)
        {
            return JsonConvert.SerializeObject(inputList);
        }
        public string Serialize(List<User> inputList)
        {
            return JsonConvert.SerializeObject(inputList);
        }
        public string Serialize(List<Order> inputList)
        {
            return JsonConvert.SerializeObject(inputList);
        }

        public List<Product> DeserializeProducts(string json)
        {
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }
        public List<User> DeserializeUsers(string json)
        {
            return JsonConvert.DeserializeObject<List<User>>(json);

        }
        public List<Order> DeserializeOrders(string json)
        {
            return JsonConvert.DeserializeObject<List<Order>>(json);
        }
    }
}