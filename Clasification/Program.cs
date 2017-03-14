using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasification
{
    enum UserType { user, admin }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product() { ProductID = 1, ProductName = "La La La" };
            Product p1 = new Product() { ProductID = 2, ProductName = "Opa" };
            Product p2 = new Product() { ProductID = 3, ProductName = "Lu La La" }; ;

            MyRepository db = new MyRepository();
            db.Add(p);
            db.Add(p1);
            db.Add(p2);
            Console.WriteLine(db.G);


            
        }
    }
}
