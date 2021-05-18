using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork11
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public String ClientName { get; set; }
        public double OrderPrice
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
        }
        public String AllOrderDetail
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (OrderDetail o in OrderDetails)
                {
                    sb.Append(o.ToString() + "\n");
                }
                return sb.ToString();
            }
        }

        public Order()
        {
            OrderID = 0;
            ClientName = null;
            OrderDetails = new List<OrderDetail>();
        }
        public Order(int orderID, String clientName)
        {
            OrderID = orderID;
            ClientName = clientName;
            OrderDetails = new List<OrderDetail>();
        }
        public void AddOrderDetails(OrderDetail od)
        {
            bool flag = true;
            foreach (OrderDetail o in OrderDetails)
            {
                if (o.Equals(od))
                {
                    o.count += od.count;
                    o.OrderDetailsPrice += od.count * od.goodPrice;
                    flag = false;
                }
            }
            if (flag == true)
            {
                OrderDetails.Add(od);
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (OrderDetail g in OrderDetails)
            {
                sb.Append(g);
            }
            return "订单号为" + OrderID + "客户为" + ClientName + "\n,商品明细" + sb.ToString() + ",总金额为" + OrderPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID;
        }

        public override int GetHashCode()
        {
            return 1651275338 + OrderID.GetHashCode();
        }
    }
}
