using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a shape drawer.");
            double sum = 0;
            for(int i = 0; i < 10; i++)
            {
                Shape theShape = ShapeDrawer.Create(ShapeDrawer.ran.Next(0, 3));
                sum += theShape.Area();
            }
            Console.WriteLine($"The sum of the area is: {sum}");
        }
    }
}
