using System;

namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a clock.");
            Clock clock = new Clock();

            clock.ClockTick += TickFunction;
            clock.ClockAlarm += AlarmFunction;
            System.Threading.Thread t1 = new System.Threading.Thread(clock.StartClockTick);
            System.Threading.Thread t2 = new System.Threading.Thread(clock.StartClockAlarm);

            t1.Start();
            t2.Start();
        }
        static void TickFunction()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        static void AlarmFunction()
        {
            Console.WriteLine("Alarm for every 5 sec!");
            
        }
    }
}
