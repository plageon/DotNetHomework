using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class ShapeDrawer
{
        public static Random ran = new Random();
        public static Shape Create(int index) {
            bool legal = false;
            Shape pen = null;
            while (!legal)
            {
                switch (index)
                {
                    case 0: pen = new Triangle(ran.Next(0, 10), ran.Next(0, 10), ran.Next(0, 10)); break;
                    case 1: pen = new Rectangle(ran.Next(0, 10), ran.Next(0, 10)); break;
                    case 2: pen = new Square(ran.Next(0, 10)); break;
                    default: break;
                }
                legal = pen.IsLegal();
            }        
            return pen;
        }
    }
}
