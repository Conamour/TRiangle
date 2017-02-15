using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           Point x1 = new Point(5, 7);
            Point y1 = new Point(6, 1);
            Point z1 = new Point(8, 3);

           Point x2 = new Point(1, 1);
            Point y2 = new Point(1, 5);
            Point z2 = new Point(8, 1);

            Point x3 = new Point(0, 1);
            Point y3 = new Point(2, 7);
            Point z3 = new Point(4, 1);

         

            Triangle[] triangleNode = new Triangle[4];

            triangleNode[0] = new Triangle(x1, y1, z1);
            triangleNode[1] = new Triangle(x2, y2, z2);
            triangleNode[2] = new Triangle(x3, y3, z3);
            
         


            for (int i = 0; i < 4; i++)
            {

                if (!triangleNode[i].Ibi)
                {
                    Console.WriteLine("Triangle {0} not exist! Check input data.", i);
                    Environment.Exit(0);
                }
            }

            double avgPerimetr = 0;
            double avgArea = 0;

            int countIs = 0;
            int countRight = 0;
            for (int i = 0;i < 4; i++)
            { 
                   if (triangleNode[i].Isosceles)
                {
                    avgArea += triangleNode[i].Area;
                    countIs++;
                }
                   if (triangleNode[i].Right)
                {
                    avgPerimetr += triangleNode[i].Perimetr;
                    countRight++;
                }

            }

            avgPerimetr /= countRight;
            avgArea /= countIs;

            Console.WriteLine("Average P = {0:F2}", avgPerimetr);
            Console.WriteLine("Average Area = {0:F2}", avgArea);

        }
    }
}
