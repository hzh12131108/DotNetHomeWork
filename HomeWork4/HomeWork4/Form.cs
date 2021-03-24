using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Form
    {
        public Clock myClock = new Clock();
        public Form()
        {
            myClock.Alarm += Alarm1;
            myClock.Tick += Tick1;
        }
        void Alarm1(Clock sender)
        {
            if(DateTime.Compare(sender.CurrentTime, sender.GoalTime)==0)
            {
                Console.WriteLine("零零零零零零！");
            }
        }
        void Tick1(Clock sender)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("tickticktick!");

        }
    }
}
