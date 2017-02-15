using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangle
    {
        Point a;
        Point b;
        Point c;


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
                bool Check;
                if ((Math.Pow(u.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(w.Length, 2)) ||
                    (Math.Pow(w.Length, 2) + Math.Pow(u.Length, 2) == Math.Pow(v.Length, 2)) || 
                    (Math.Pow(w.Length, 2) + Math.Pow(v.Length, 2) == Math.Pow(u.Length, 2)))
                {
                    Check = true;
                }
               
                    else Check = false;
               
                return Check;
            }
        }
        public bool Isosceles
        {
            get
            {
                bool Check; 
                if ((u.Length == v.Length && u.Length != w.Length)||
                    (u.Length == w.Length && u.Length != v.Length)||
                    (w.Length == v.Length && w.Length != u.Length))
                {
                    Check = true;
                }
                
                    else Check = false;
                
                return Check;
            }
        }
        public bool Ibi
        {
            get
            {
                bool check; 
                if (((v.Length + u.Length)>w.Length)|| ((w.Length + u.Length) > v.Length)|| ((v.Length + w.Length) > u.Length))
                {
                    check = true;
                }
                
                    else check = false;
                
                return check;
            }
        }

    }  
 }
