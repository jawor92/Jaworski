using System;
using System.Collections.Generic;

namespace Jaworski.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int OrderID)
        {
            this.OrderID = OrderID;
        }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        //Methods
        /// <summary>
        /// Check data of order
        /// </summary>
        /// <returns></returns>
        public bool ValidateData()
        {
            var ProperVal = true;

            if (OrderDate == null)
                ProperVal = false;

            return ProperVal;
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
        /// <summary>
        /// This method will be download one, particluar order data
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public Order DownloadData(int OrderID)
        {
            // code to download OrderID data
            return new Order();
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

    }
}
