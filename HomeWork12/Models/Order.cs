using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork12.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public String ClientName { get; set; }
       /* public double OrderPrice
        {
            get
            {
                double sum = 0;
                foreach (OrderDetail o in OrderDetails)
                {
                    sum += o.OrderDetailsPrice;
                }
                return sum;
            }
            set { }
        }*/
      
    }
}
