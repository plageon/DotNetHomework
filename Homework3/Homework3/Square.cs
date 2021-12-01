using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Square:Shape
    {
        public int edge
        {
            get;
            set;
        }
        public bool legal { get; }

        public bool IsLegal()
        {
            if (edge <= 0)
                return false;
            else return true;
        }
        public Square(int edge){
            this.edge = edge;
            legal = IsLegal();
            if (legal)
            {
                Console.WriteLine($"A square has been created!, its edge is: {edge}");
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
                return edge * edge;
            }
            else
            {
                return -1;
            }

        }

    }
}
