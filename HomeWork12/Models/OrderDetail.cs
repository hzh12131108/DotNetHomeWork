using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork12.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public String goodName { get; set; }
        public double goodPrice { get; set; }
        public int count { get; set; }
        /*public double OrderDetailsPrice { get; set; }*/

        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
