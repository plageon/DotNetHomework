using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4_2
{
    class Clock
    {
        public event Action ClockTick;
        public event Action ClockAlarm;
        public void StartClockTick()
        {
            
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                ClockTick();
            }
        }
        public void StartClockAlarm()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(5000);
                ClockAlarm();
            }
        }
    }
}
