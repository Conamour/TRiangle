using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Edge
    {
        public Point a;
        public Point b; 
    public Edge (Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }
    public double Length
        {
            get 
            {
                return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
            }
        }
        public static bool operator ==(Edge v, Edge w)
        {
            return w.Length == v.Length;
        }

        public static bool operator !=(Edge v, Edge w)
        {
            return !(w.Length == v.Length);
        }
    }
}
