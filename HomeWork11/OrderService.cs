using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class OrderService
    {
        public static void AddOrder(int OrderID,string ClientName)
        {
            using (OrderContext db = new OrderContext())
            {
                var Order = new Order() { OrderID=OrderID,ClientName=ClientName};
                db.Orders.Add(Order);
                db.SaveChanges();
            }
        }

        public static void DeleteOrder(int OrderID)
        {
            using (OrderContext db = new OrderContext())
            {
                var order = db.Orders.Include("OrderDetails").FirstOrDefault(p => p.OrderID == OrderID);
                if(order!=null)
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }else
                {
                    throw new Exception("该订单不存在！");
                }
            }
        }
        //修改订单，通过订单ID修改顾客名称
        public static void ModifyOrder(int orderID,string clientname)
        {
            using (OrderContext db = new OrderContext())
            {
                var order = db.Orders.FirstOrDefault(p => p.OrderID == orderID);
                if (order != null)
                {
                    order.ClientName = clientname;
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("该订单不存在！");
                }
            }
        }

        public static void AddOrderDetail(int OI,string goodName,double goodPrice,int count)
        {
            using (OrderContext db = new OrderContext())
            {
                var OD = new OrderDetail(goodName,count,goodPrice);
                OD.OrderID = OI;
                db.OrderDetails.Add(OD);
                db.SaveChanges();
            }
        }

        public static void DeteleOrderDetail(int OI,string goodname)
        {
            using (OrderContext db = new OrderContext())
            {
                var query = db.OrderDetails.Where(p => p.goodName == goodname && p.OrderID == OI);
                OrderDetail od = query.FirstOrDefault();
                if(od!=null)
                {
                    db.OrderDetails.Remove(od);
                    db.SaveChanges();
                }else
                {
                    throw new Exception("该订单明细不存在！");
                }
            }
        }

        public static List<Order> QueryOrder(int index,string arg)
        {
            List<Order> orders = null;
            using(OrderContext db = new OrderContext())
            {
                switch (index)
                {
                    case 0:
                        orders = db.Orders.Where(p => p.OrderID != 0).ToList();
                        break;
                    case 1:
                        int i = Int32.Parse(arg);
                        orders = db.Orders.Where(p => p.OrderID == i).ToList();
                        break;
                    case 2:
                        orders = db.Orders.Where(p => p.ClientName == arg).ToList();
                        break;
                    case 3:
                        double d = Double.Parse(arg);
                        orders = db.Orders.Where(p => p.OrderPrice == d).ToList();
                        break;
                    default:
                        break;
                }
            }

            return orders;
           
        }





    }
}
