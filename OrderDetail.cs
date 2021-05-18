using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeWork11
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        
        public String goodName { get; set; }
        public double goodPrice { get; set; }
        public int count { get; set; }
        public double OrderDetailsPrice { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }
        public OrderDetail() { }
        public OrderDetail(String goodName, int count, double goodPrice)
        {
            this.goodName = goodName;
            this.count = count;
            this.goodPrice = goodPrice;
            this.OrderDetailsPrice = goodPrice * count;
        }

        public override string ToString()
        {
            return "商品" + goodName + ":" + count + "件";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetail details &&
                   goodName == details.goodName;
        }

        public override int GetHashCode()
        {
            return 1625374611 + EqualityComparer<string>.Default.GetHashCode(goodName);
        }
    }
}
