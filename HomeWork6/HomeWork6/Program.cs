using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("hzh");
            Client c2 = new Client("aaa");
            Client c3 = new Client("bbb");

            Goods g1 = new Goods("上衣", 100);
            Goods g2 = new Goods("裤子", 80);
            Goods g3 = new Goods("帽子", 20);
            Goods g4 = new Goods("鞋子", 100);

            Order o1 = new Order(20193021, c1);
            OrderDetails od1 = new OrderDetails(g1, 2);
            o1.AddOrderDetails(od1);
            Console.WriteLine(od1);
            o1.AddOrderDetails(new OrderDetails(g2, 1));
            Order o2 = new Order(20193022, c2);
            o2.AddOrderDetails(new OrderDetails(g1, 4));
            o2.AddOrderDetails(new OrderDetails(g4, 2));
            Order o3 = new Order(20193023, c3);
            o3.AddOrderDetails(new OrderDetails(g2, 3));
            o3.AddOrderDetails(new OrderDetails(g3, 2));

            OrderService.AddOrder(o1);
            OrderService.AddOrder(o2);
            OrderService.AddOrder(o3);
            OrderService.DeleteOrder(20193021);
            OrderService.PrintOrder();
            OrderService.InquireOrder();
            /*OrderService.Export();
            OrderService.Import();*/
        }
    }

    [Serializable]
    public class Client
    {
        public String CName { get; set; }

        public Client() { }
        public Client(string cName)
        {
            CName = cName;
        }

        public override string ToString()
        {
            return CName;
        }
    }
    [Serializable]
    public class Goods
    {
        public Goods() { }
        public String GName { get; set; }
        public double Price { get; set; }
        public Goods(String name, double price)
        {
            GName = name;
            Price = price;
        }

        public override string ToString()
        {
            return GName;
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   GName == goods.GName;
        }
        public override int GetHashCode()
        {
            return 310756525 + EqualityComparer<string>.Default.GetHashCode(GName);
        }
    }

    [Serializable]
    public class OrderDetails
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public double OrderDetailsPrice { get; set; }
        public OrderDetails() { }
        public OrderDetails(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
            this.OrderDetailsPrice = goods.Price * count;
        }

        public override string ToString()
        {
            return "商品" + goods.GName + ":" + count + "件";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Goods>.Default.Equals(goods, details.goods);
        }

        public override int GetHashCode()
        {
            int hashCode = -962798899;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            return hashCode;
        }
    }
    [Serializable]
    public class Order
    {
        public int OrderID { get; set; }
        public List<OrderDetails> OrderDetailsLits;
        public Client Client { get; set; }
        public double OrderPrice
        {
            get
            {
                double sum = 0;
                foreach (OrderDetails o in OrderDetailsLits)
                {
                    sum += o.OrderDetailsPrice;
                }
                return sum;
            }
        }

        public Order()
        {
            OrderID = 0;
            Client = null;
            OrderDetailsLits = new List<OrderDetails>();
        }
        public Order(int orderID, Client client)
        {
            OrderID = orderID;
            Client = client;
            OrderDetailsLits = new List<OrderDetails>();
        }
        public void AddOrderDetails(OrderDetails od)
        {
            bool flag = true;
            foreach (OrderDetails o in OrderDetailsLits)
            {
                if (o.Equals(od))
                {
                    o.count += od.count;
                    o.OrderDetailsPrice += od.count * od.goods.Price;
                    flag = false;
                }
            }
            if (flag == true)
            {
                OrderDetailsLits.Add(od);
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (OrderDetails g in OrderDetailsLits)
            {
                sb.Append(g);
            }
            return "订单号为" + OrderID + "客户为" + Client + "\n,商品明细" + sb.ToString() + ",总金额为" + OrderPrice;
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
    [Serializable]
    public class OrderService
    {


        static List<Order> OrderList = new List<Order>();

        public OrderService() { }
        public static void PrintOrder()
        {
            foreach (Order o in OrderList)
            {
                Console.WriteLine($"{o}");
            }
        }
        public static void AddOrder(Order o)
        {
            var or = from n in OrderList
                     where n.Equals(o)
                     select n;
            if (or == null)
            {
                throw new ArgumentException("该订单已存在！");
            }
            else
            {
                OrderList.Add(o);
            }
        }

        public static void DeleteOrder(int OrderIDToBeDeleted)
        {
            int index = -1;
            foreach (Order o in OrderList)
            {
                if (o.OrderID == OrderIDToBeDeleted)
                {
                    index = OrderList.IndexOf(o);

                }
            }
            if (index != -1)
            {
                OrderList.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException("订单已存在！");
            }
        }

        public static void ModifyOrder(int OrderIDToBeModified, OrderDetails od)
        {
            var or = (Order)(from n in OrderList
                             where n.OrderID == OrderIDToBeModified
                             select n);
            if (or != null)
            {
                or.AddOrderDetails(od);
            }
            else
            {
                throw new ArgumentException("该订单不存在");
            }
        }

        public static void InquireOrder()
        {
            Console.WriteLine("按照金额查询请输入1，按照客户名称查询请输入2，按照商品名称查询请输入3，按照订单号查询请输入4");
            int index = Int32.Parse(Console.ReadLine());
            switch (index)
            {
                case 1:
                    Console.WriteLine("请输入要查询的金额：\n");
                    int priceNum = Int32.Parse(Console.ReadLine());
                    var query1 = from s1 in OrderList
                                 where s1.OrderPrice == priceNum
                                 orderby s1.OrderPrice
                                 select s1;
                    List<Order> o1 = query1.ToList();
                    Console.WriteLine($"查询结果为{o1.ToString()}");
                    break;
                case 2:
                    Console.WriteLine("请输入要查询的客户姓名：\n");
                    String nameQuery = Console.ReadLine();
                    var query2 = from s2 in OrderList
                                 where s2.Client.CName == nameQuery
                                 orderby s2.OrderPrice
                                 select s2;
                    List<Order> o2 = query2.ToList();
                    foreach (Order s2 in o2)
                    {
                        Console.WriteLine($"查询结果为{s2}");
                    }
                    break;
                case 3:
                    Console.WriteLine("请输入要查询的商品名称：\n");
                    String nameObjecct = Console.ReadLine();
                    List<Order> o3 = new List<Order>();
                    foreach (Order o in OrderList)
                    {
                        foreach (OrderDetails od in o.OrderDetailsLits)
                        {
                            if (od.goods.GName == nameObjecct)
                            {
                                o3.Add(o);
                            }
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("请输入要查询的订单号：\n");
                    int OrderIDQuery = Int32.Parse(Console.ReadLine());
                    var query4 = from s4 in OrderList
                                 where s4.OrderID == OrderIDQuery
                                 orderby s4.OrderPrice
                                 select s4;
                    List<Order> o4 = query4.ToList();
                    foreach (Order o in o4)
                    {
                        Console.WriteLine($"查询结果为{o}");
                    }
                    break;
                default:
                    break;
            }

        }

        public static void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderList);
            }
        }

        public static void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> a = (List<Order>)xmlSerializer.Deserialize(fs);
                foreach (Order o in a)
                {
                    Console.WriteLine(o);
                }
            }

        }

    }
}
