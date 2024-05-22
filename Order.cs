using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_8
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public List<OrderProduct> Products { get; set; }
    }
}
