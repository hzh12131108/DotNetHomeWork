using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for(int x = 0; x<10;x++)
            {
                list.Add(x);
            }
            Console.WriteLine("打印链表为：");
            list.ForEach(m=>Console.WriteLine(m));
            int max = 0, min = 0;
            list.ForEach(m =>
            {
                if(m>max)
                {
                    max = m;
                }
            });
            list.ForEach(m =>
            {
                if(m<min)
                {
                    min = m;
                }
            });
            Console.WriteLine($"元素最大值为{max},元素最小值为{min}");
            int sum = 0;
            list.ForEach(m => sum += m);
            Console.WriteLine($"链表元素之和为{sum}");
            int n = 0;
            list.ForEach(m =>n++);
            Console.WriteLine($"元素平均值为{(double)sum / (double)n}");


            Form form1 = new Form();
            form1.myClock.GoalTime = Convert.ToDateTime("08:00:00");
            form1.myClock.OpenClock();
        }
    }
}
