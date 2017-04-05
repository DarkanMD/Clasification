using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class Order
    {
        List<ICartProduct> _products = new List<ICartProduct>();
        IRepository<User> rep;

        public Order(List<ICartProduct> listOfProducts, Guid userID,DateTime dueDate)
        {
            OrderID = Guid.NewGuid();
            _products = listOfProducts;
            UserID = userID;
            OrderDueDate = DateTime.Now;
            OrderShippingAddress = rep.Get(x=>x.UserID==userID).FirstOrDefault().UserAddress ;
            OrderDueDate = dueDate;

        }
        public Guid OrderID { get; private set; }

        public string OrderShippingAddress { get; private set; }

        public DateTime OrderDueDate { get; private set; }

        public Guid UserID { get; private set; }

    }
}