using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clasification
{
    public class Order
    {
        private int _orderID;
        private int _userID;
        private string _orderShippingAdress;
        private DateTime _orderDueDate;
        private string _orderShipingDetails;

        public int OrderID
        {
            get
            {
                return _orderID;
            }

            set
            {
                _orderID = value;
            }
        }

        public string OrderShippingAdress
        {
            get
            {
                return _orderShippingAdress;
            }

            set
            {
                _orderShippingAdress = value;
            }
        }

        public DateTime OrderDueDate
        {
            get
            {
                return _orderDueDate;
            }

            set
            {
                _orderDueDate = value;
            }
        }

        public string OrderShipingDetails
        {
            get
            {
                return _orderShipingDetails;
            }

            set
            {
                _orderShipingDetails = value;
            }
        }

        public int UserID
        {
            get
            {
                return _userID;
            }

            set
            {
                _userID = value;
            }
        }
    }
}