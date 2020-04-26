using System;
using System.Collections.Generic;

namespace Jaworski.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// This method will be download one, particluar order data
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public Order DownloadData(int OrderID)
        {
            Order Order = new Order(OrderID);

            //temporary hardoced order 
            if (OrderID == 10)
            {
                Order.OrderDate = new DateTimeOffset(2018, 4, 20, 11,00,00, new TimeSpan(7,0,0));
            }

            // code to download OrderID data
            return Order;
        }
        /// <summary>
        /// Download all orders data
        /// </summary>
        /// <returns></returns>
        public List<Order> DownloadData()
        {
            //Code can download all order data
            return new List<Order>();
        }
        /// <summary>
        /// This method will be saved order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code to saved defined order
            return true;
        }

        public OrderDisplay TakeOrderToDisplay(int OrderID)
        {
            OrderDisplay orderDis = new OrderDisplay();

            if (OrderID == 10)
            {
                orderDis.Name = "Mateusz";
                orderDis.LastName = "Kowal";
                orderDis.DateOrder = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0));

            }
        }
    }
}
