using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Rectangle:Shape
{
        public int length {
            get;
            set;      
        }
        public int width {
            get; 
            set; 
        }
        public bool legal { get; }
        public bool IsLegal()
        {
            if (length <= 0 || width <= 0)
                return false;
            else return true;
        }
        public Rectangle(int a, int b)
        {
                length = a;
                width = b;
            this.legal = IsLegal();
         if(legal)
            {
                Console.WriteLine($"A rectangle has been created!, its edges are: {length},{width}");
            }
         else
            {
                Console.WriteLine("Create failed!");
            }
        }
        public double Area()
        {
            if (legal)
            {
                return length * width;
            }
            else
            {
                return -1;
            }
            
        }
}
}
