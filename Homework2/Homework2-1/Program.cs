using System;

namespace Homework2_1
{
    class Program
    {
        static int[] Pnumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Please enter an integer.");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                DoFactor(x);
            }
            else Console.WriteLine("Please input a integer");
        }
        static void DoFactor(int x)
        {
            int remain = x;
            foreach(int p in Pnumbers)
            {
                while (remain % p == 0)
                {
                    remain /= p;
                    Console.WriteLine(p.ToString());
                }
                if (remain == 0)
                {
                    break;
                }
            }
        }
    }
}
