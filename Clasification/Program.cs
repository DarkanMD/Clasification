using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject;

namespace Clasification
{
    enum UserType { user, admin }
    class Program
    {
        static void Main(string[] args)
        {

            //User u = userFactory.Create("Ion","Chisinau","Ion@gmail.com");
            //User u1 = userFactory.Create("Vasea","Chisinau","vasiOK@gmail.com");
            //User u2 = userFactory.Create("Oleg","Monaco","Oleg@gmail.com");
            //User u3 = userFactory.Create("Dan","Moon","Dan@gmail.com");
            //User u4 = userFactory.Create("Eugen","Uagadugu","Eugen@gmail.com");

            //Product p = productFactory.Create("Camera 2Mpx","Camera", "Camera", 120, 10,true);
            //Product p1 = productFactory.Create("PTZ 2Mpx", "Camera", "PTZ", 400, 3, true);
            //Product p2 = productFactory.Create("Camera 4Mpx", "Camera", "Camera", 190, 15, true);
            //Product p3 = productFactory.Create("PTZ 4Mpx", "Camera", "PTZ", 500, 2, true);
            //Product p4 = productFactory.Create("Spy CAM 2Mpx", "Camera", "SPY", 250, 5, true);
            //Product p5 = productFactory.Create("Camera 1Mpx", "Camera", "Camera", 90, 25, true);
            //Product p6 = productFactory.Create("Camera 1.3Mpx", "Camera", "Camera", 120, 10, true);
            //Product p7 = productFactory.Create("Camera 2.4Mpx", "Camera", "Camera", 160, 18, true);
            //Product p8 = productFactory.Create("Camera 2Mpx", "Camera", "Camera", 120, 18, true);
            //Product p9 = productFactory.Create("Camera 2Mpx", "Camera", "Camera", 100, 18, true);
            //Product p10 = productFactory.Create("Camera 3Mpx", "Camera", "Camera", 110, 18, true);

            ProductFactory productFactory = new ProductFactory();
            UserFactory userFactory = new UserFactory();
            TextRepository<Product> products = new TextRepository<Product>();
            TextRepository<User> users = new TextRepository<User>();

            //users.Add(new List<User> { u, u1, u2, u3, u4 });
            //products.Add(new List<Product> { p5, p6, p7, p8, p9, p10 });

            //products.Delete(p);
            //products.Add(Factory.Create());
            var qwery = TextRepository<Product>.GetPagedResultForQuery(products.Get(x => x.ProductName.ToUpper().Contains("Camera".ToUpper())).OrderBy(x => x.ProductPrice), 2, 5);
            Console.WriteLine($"{"Name",-15} {"Price",-10} {"In stock",-20}");

            ShopingCart myCart = new ShopingCart();
            //     myCart.AddToCart(products.Get(x => x.ProductName.ToUpper().Contains("spy".ToUpper())).FirstOrDefault(), 10);


            Display(qwery.Results.ToList());
            Console.WriteLine($"Page { qwery.CurrentPage}/{qwery.PageCount}");
            //foreach (var item in qwery)
            //{
            //    Console.WriteLine($"{++counter,-6}{item.ProductName,-15} {item.ProductPrice,-10} {item.ProductStock,-20}" );
            //}
            var qwery2 = users.Get(x => x.UserName.ToUpper() == "vasea".ToUpper());

            Console.WriteLine($"{"Name",-20} {"Email",-20} {"ID",-35}");
            foreach (var item in qwery2)
            {
                Console.WriteLine($"{item.UserName,-20} {item.UserEmailAddress,-20} {item.UserID,-35}");
            }
            Console.ReadKey();
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
            int counter = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"{++counter,-6}{item.ProductName,-15} {item.ProductPrice,-10:C} {item.ProductStock,-20}");
            }
        }

        public static void Display(Product p)
        {
                Console.WriteLine(p);
        }


    }
}
