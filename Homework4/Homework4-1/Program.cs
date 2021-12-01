using System;

namespace Homework4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ram = new Random();
            Console.WriteLine("This is a test for generic list and lambda operation.");
            GenericList<int> list = new GenericList<int>();
            int max = 0, min = 0, sum = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Add(ram.Next(0, 20));
            }
            list.ForEach(x=> Console.WriteLine($"{x}"));
            list.ForEach(x =>
            {
                if (x > max) max = x;
                if (x < min) min = x;
                sum += x;
            });
            Console.WriteLine($"The max is {max},the min is {min}, and the sum is {sum}");
        }
    }
}
