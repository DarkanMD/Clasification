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
            MyRepository db = new MyRepository();
            User u = new User(1, "Ion");
            User u1 = new User(2, "Vasea");
            User u2 = new User(3, "Oleg");

            db.Add(u);
            db.Add(u1);
            db.Add(u2);

            Product p = new Product(1,"Camera 2Mpx",120,"Camera");
            Product p1 = new Product(2,"PTZ 2Mpx",400, "PTZ");
            Product p2 = new Product(3,"Camera 4Mpx",190,"Camera");
            Product p3 = new Product(4,"PTZ 4Mpx",500,"PTZ" );
            Product p4 = new Product(5,"Spy CAM 2Mpx",250,"SPY");

            db.Add(p);
            db.Add(p1);
            db.Add(p2);
            db.Add(p3);
            db.Add(p4);

            //Console.WriteLine("Now showing Spy cams");
            //Display(db.GetAllProducts().Where(x => x.ProductType.ToUpper() == "spy".ToUpper()).ToList());
            //Console.WriteLine();
            //Console.WriteLine("Now showing PTZ");
            //Display(db.GetAllProducts().Where(x => x.ProductType.ToUpper() == "ptz".ToUpper()).ToList());
            //Console.WriteLine();
            //Console.WriteLine("Now showing 2Mpx Products and ORDERED");
            //Display(db.GetAllProducts().Where(x => x.ProductName.ToUpper().Contains("2mpx".ToUpper())).OrderByDescending(x => x.ProductName).ToList()); //ordered
            //Console.WriteLine();
            //Console.WriteLine("Now showing 2Mpx cameras");
            //Display(db.GetAllProducts().Where(x => x.ProductName.ToUpper().Contains("2mpx".ToUpper()) && x.ProductType.ToUpper() == "camera".ToUpper()).ToList());

            //Console.WriteLine();
            //Console.WriteLine("Select");
            //Console.WriteLine("Geting product ID of the PTZ");
            //Display(db.GetAllProducts().Where(x => x.ProductType.ToUpper() == "ptz".ToUpper()).Select(x => x.ProductID.ToString()).ToList());

            //var grouped = db.GetAllProducts().GroupBy(x => x.ProductType).ToList();  //grouped

            //ShopingCart cart1 = new ShopingCart() { UserID=2};
            //cart1.Add(new CartProduct(p,10));
            //cart1.Add(new CartProduct(p3,1));
            //ShopingCart cart2 = new ShopingCart() { UserID=3};
            //cart2.Add(new CartProduct(p1,2));
            //cart2.Add(new CartProduct(p2,1));

            //List<ShopingCart> myShopingCarts = new List<ShopingCart>();
            //myShopingCarts.Add(cart1);
            //myShopingCarts.Add(cart2);
            //var result = myShopingCarts.SelectMany(x => x.CartProducts);

            //var united = cart1.GetAllCartProducts().Union(cart2.GetAllCartProducts());  //union

            //Console.WriteLine();
            //Console.WriteLine("SelectMany");
            //Display(result.ToList());
            //Console.WriteLine();
            //Console.WriteLine("Joining");
            //var joinedStuff = from mycarts in myShopingCarts                                                //oldstype
            //                  join uzeri in db.GetAllUsers() on mycarts.UserID equals uzeri.UserID
            //                  orderby mycarts.CartTotal
            //                  select  uzeri.UserName +" "+ mycarts.CartTotal.ToString();

            //Display(joinedStuff);

            //Console.WriteLine();
            //Console.WriteLine("Count Max");
            //Console.WriteLine("we have {0} products in our db",db.GetAllProducts().Count(x=>x.ProductPrice>200)); ;
            //Console.WriteLine("the Max price in our price list is {0}",db.GetAllProducts().Max(x=> x.ProductPrice));
            //Console.WriteLine("the Max ID in our price list is {0}", db.GetAllProducts().Max(x => x.ProductID));

            //Console.WriteLine();
            //Console.WriteLine("Quantifiers Contains");
            //Console.WriteLine(db.GetAllUsers().Any(x=>x.UserName.ToUpper() =="Vasea".ToUpper()));


            //Product forSerial = new Product(10, 123, 10, "Camera 2Mpx", "Camera", true);
          //  db.Save();
            var myQuery = db.GetAllProducts()/*.Where(x=>x.ProductType.ToUpper()=="camera".ToUpper())*/;


            foreach (var item in myQuery)
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
