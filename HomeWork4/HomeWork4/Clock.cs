using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public delegate void ClockHandler(Clock sender);
    public class Clock
    {
        public event ClockHandler Alarm;
        public event ClockHandler Tick;
        public DateTime CurrentTime { get; set; }
        public DateTime GoalTime { get; set; }
        public Clock()
        {
            CurrentTime = new System.DateTime();
        }
        public void OpenClock()
        {
            Console.WriteLine("闹钟开启！");
            Tick(this);
            Alarm(this);
        }
    }
}
