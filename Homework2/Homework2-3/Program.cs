using System;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This part is for Ayth's method to get the prime number between 2 and 100.");
            int[] x = new int[99];
            for(int i = 0; i < 99; i++)
            {
                x[i] = i + 2;
                if (x[i] != 2 && x[i] % 2 == 0) x[i] = 0;
                if (x[i] != 3 && x[i] % 3 == 0) x[i] = 0;
                if (x[i] != 5 && x[i] % 5 == 0) x[i] = 0;
                if (x[i] != 7 && x[i] % 7 == 0) x[i] = 0;
            }
            foreach(int temp in x)
            {
                if (temp != 0) Console.WriteLine(temp);
            }
        }
    }
}
