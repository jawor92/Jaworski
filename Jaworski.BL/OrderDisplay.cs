using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaworski.BL
{
    public class OrderDisplay
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? DateOrder { get; set; }
        public List<OrderDisplayPosition> OrderDisplayList { get; set; }
        public int OrderID { get; set; }
        public Address DeliveryAddress { get; set; }

    }
}
