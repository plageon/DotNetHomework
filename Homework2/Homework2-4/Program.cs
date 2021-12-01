using System;

namespace Homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.WriteLine("Please enter the scale of the matrix,first M then N.");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out M))
                {
                    Console.WriteLine("Then N");
                    if (int.TryParse(Console.ReadLine(), out N))
                    {
                        Console.WriteLine("now the values.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, enter again");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, enter again");
                    continue;
                }
            }    
            int[,] myMatrix = new int[M, N];
            Console.WriteLine("Please enter groups of number to create a matrix.");
            int count = 0;
            int temp = 0;
            while (count < M * N)
            {
                if (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Invalid number! enter again.");
                    continue;
                }
                else
                {
                    myMatrix[(count - count % N) / N, count % N] = temp;
                    count++;
                }              
            }
            Toeplitz(myMatrix);
        }
        static void Toeplitz(int [,] theMatrix)
        {
            if (theMatrix.GetLength(0) > theMatrix.GetLength(1))
            {
                bool tag = true;
                int i = 0;
                while (i < theMatrix.GetLength(1))
                {
                    tag = tag && check(theMatrix, 0, i);
                    i++;
                }
                i = 0;
                while (i < theMatrix.GetLength(0))
                {
                    tag = tag && check(theMatrix, i, 0);
                    i++;
                }
                Console.WriteLine(tag);
            }
            else
            {
                bool tag = true;
                int i = 0;
                while (i < theMatrix.GetLength(0))
                {
                    tag = tag && check(theMatrix, i, 0);
                    i++;
                }
                i = 0;
                while (i < theMatrix.GetLength(1))
                {
                    tag = tag && check(theMatrix, 0, i);
                    i++;
                }
                Console.WriteLine(tag);
            }
        }
        static bool check(int[,] x, int length, int width) {
            if (length + 1 >= x.GetLength(0) || width + 1 >= x.GetLength(1)) return true;
            bool self = false;
            bool flag = false;
            flag=check(x, length + 1, width + 1);
            self = (x[length, width] == x[length + 1, width + 1]);
            return (self && flag);
        }
    }
}
