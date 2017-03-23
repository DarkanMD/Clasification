using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    class Factory
    {

        public static Product Create ()
        {
            int id = ID();
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product category: ");
            string category = Console.ReadLine();
            decimal price = Price();
            int stock = Stock();
            bool visible = Visible();
            return new Product(id,productName,category,price,stock,visible);
        }

        public static decimal Price()
        {
            Console.Write("Product price: ");
            string read = Console.ReadLine();
            decimal price;
            if (!(decimal.TryParse(read, out price)))
            {
                Console.WriteLine("Price should be a number");
                return Price();
            }
            else return price;

        }
        public static int Stock()
        {
            Console.Write("Product stock: ");
            string read = Console.ReadLine();
            int  stock;
            if (!(int.TryParse(read, out stock)))
            {
                Console.WriteLine("Stock should be a integer");
                return Stock();
            }
            else return stock;
        }

        public static bool Visible()
        {
            Console.Write("Product is visible(true/false): ");
            string read = Console.ReadLine();
            bool visible;
            if (!(bool.TryParse(read, out visible)))
            {
                Console.WriteLine("Only true / false is acepted as input");
                return Visible();
            }
            else return visible;
        }

        public static int ID()
        {
            Console.Write("Product ID: ");
            string read = Console.ReadLine();
            int id;
            if (!(int.TryParse(read, out id)))
            {
                Console.WriteLine("ID must be an integer");
                return ID();
            }
            else return id;
        }
    }
}
