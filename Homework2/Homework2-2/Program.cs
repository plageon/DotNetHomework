using System;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[20];
            int i = 0;
            Console.WriteLine("Please enter the number group. Type any non-number word to end the input.");
            while (int.TryParse(Console.ReadLine(),out int temp))
            {
                if (i >= 20) break;
                x[i] = temp;
                i++;
            }
            aboutNumber(x);
        }
        static void aboutNumber(int[] x) {
            int maxNum = 0;
            int minNum = 0;
            int sum = 0;
            int count = 0;
            foreach(int a in x)
            {
                if (a > maxNum) maxNum = a;
                if (a < minNum) minNum = a;
                sum += a;
                count++;
            }
            Console.WriteLine($"The maximum number is {maxNum}");
            Console.WriteLine($"The minimum number is {minNum}");
            Console.WriteLine($"The average is {(double)sum/count},and the sum is {sum}");
        }
    }
}
