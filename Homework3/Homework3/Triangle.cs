using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Triangle : Shape
    {
        public int edge1 { get; set; }
        public int edge2{get;set;}
        public int edge3 { get; set; }
        public bool legal { get; }

        public bool IsLegal()
        {
            if (edge1 + edge2 <= edge3 || edge1 + edge3 <= edge2|| edge2 + edge3 <= edge1) return false;
            else return true;
        }
        public Triangle(int a,int b, int c)
        {
            edge1 = a;
            edge2 = b;
            edge3 = c;
            legal = IsLegal();
            if (legal)
            {
                Console.WriteLine($"a triangle has been created!, its edges are: {edge1},{edge2},{edge3}");
            }
            else
            {
                Console.WriteLine("Create failed!");
                edge1 = edge2 = edge3 = 1;
            }
        }
        public double Area()
        {
            if (legal)
            {
                double p = (edge1 + edge2 + edge3) / 2;
                return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            }
            else
            {
                return -1;
            }

        }
    }
}
