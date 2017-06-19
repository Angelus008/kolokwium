using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    class Rectangle
    {
        
        
            public Point A { get; set; }
            public Point B { get; set; }
            public Point C { get; set; }
            public Point D { get; set; }

            public Rectangle(Point a, Point b, Point c, Point d)
            {
                A = a;
                B = b;
                C = c;
                D = d;

                CheckIfExists();
            }

            public bool CheckIfExists()
            {
                return true;
            }
        }
    }


