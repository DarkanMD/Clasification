using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    enum UserType { user, admin }
    class Program
    {
        static void Main(string[] args)
        {
            //var myguid = Guid.NewGuid();
            //MyRepository db = new MyRepository();
            User u = new User("Ion");
            User u1 = new User("Vasea");
            User u2 = new User("Oleg");
            User u3 = new User("Dan");
            User u4 = new User("Eugen");

            Product p = new Product( "Camera 2Mpx","Camera", "Camera", 120, 10,true);
            Product p1 = new Product( "PTZ 2Mpx", "Camera", "PTZ", 400, 3, true);
            Product p2 = new Product( "Camera 4Mpx", "Camera", "Camera", 190, 15, true);
            Product p3 = new Product( "PTZ 4Mpx", "Camera", "PTZ", 500, 2, true);
            Product p4 = new Product( "Spy CAM 2Mpx", "Camera", "SPY", 250, 5, true);

            TextRepository<Product> products = new TextRepository<Product>(new ProductFactory());
            TextRepository<User> users = new TextRepository<User>(new UserFactory());

             // users.Add(new List<User> { u, u1, u2, u3, u4 });
            //  products.Add(new List<Product> { p, p1, p2, p3, p4 });

            //users.Add(u);
            //users.Add(u1);
            //users.Add(u2);

            // products.Add(p);
            //products.Add(p1);
            //products.Add(p2);
            //products.Add(p3);
            //products.Add(p4);

            //products.Delete(p);
            //products.Add(Factory.Create());
            var qwery = products.Get(x => x.ProductCategory.Contains("Camera"));
            Console.WriteLine($"{"Name",-15} {"Price",-10} {"In stock",-20}");
            foreach (var item in qwery)
            {
                Console.WriteLine($"{item.ProductName,-15} {item.ProductPrice,-10} {item.ProductStock,-20}" );
            }
            var qwery2 = users.GetAll();

            foreach (var item in qwery2)
            {
                Console.WriteLine(item.ToString());
            }
        }



        public static void Display(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Display(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        public static void Display(List<CartProduct> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Display(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Display(Product p)
        {
                Console.WriteLine(p);
        }


    }
}
