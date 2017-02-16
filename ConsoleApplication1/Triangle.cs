using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
       public Point a;
       public Point b;
       public Point c;


        Edge u;
        Edge v;
        Edge w;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            this.u = new Edge(a, b);
            this.v = new Edge(b, c);
            this.w = new Edge(c, a);

            try
            {
                if (!(((v.Length + u.Length) > w.Length) &&
                    ((w.Length + u.Length) > v.Length) &&
                    ((v.Length + w.Length) > u.Length)))
                {
                    throw new Exception(string.Format("Triangle not exist!"));
                }
            }
            catch
            {
                //Console.WriteLine("Triangle ({0}:{1}) ({2}:{3}) ({4}:{5}) not exist! Check input data.", a.X, a.Y, b.X, b.Y, c.X, c.Y);
                //Environment.Exit(0);
            }
        }
        
        public double Perimetr
        {
            get
            {
                return u.Length + w.Length + v.Length;
            }
        }
        
        public double Area
        {
            get
            {
                double pp = Perimetr / 2;
                return Math.Sqrt(pp * (pp- u.Length) * (pp - v.Length) * (pp - w.Length));
            }
        }
        public bool Right
        {
            get
            {
                return (Math.Pow(u.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(w.Length, 2)) ||
                       (Math.Pow(w.Length, 2) + Math.Pow(u.Length, 2) == Math.Pow(v.Length, 2)) ||
                       (Math.Pow(w.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(u.Length, 2));
            }
        }
        public bool Isosceles
        {
            get
            {
                return ((u.Length == v.Length && u.Length != w.Length) ||
                        (u.Length == w.Length && u.Length != v.Length) ||
                        (w.Length == v.Length && w.Length != u.Length));
            }
        }

    }  
 }
