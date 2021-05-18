using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试添加订单
            OrderService.AddOrder(1, "hzh");
            OrderService.AddOrder(2, "aaa");
            OrderService.AddOrder(3, "bbb");

            //测试删除订单
            OrderService.DeleteOrder(2);

            //测试修改订单
            OrderService.ModifyOrder(1, "ccc");

            //测试添加订单明细
            OrderService.AddOrderDetail(1, "Java", 30, 5);
            OrderService.AddOrderDetail(1, "Python", 29, 4);

            //测试删除订单明细
            OrderService.DeteleOrderDetail(1, "Java");

            //测试查询订单
            List<Order> list = OrderService.QueryOrder(2, "bbb");
            foreach(Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
