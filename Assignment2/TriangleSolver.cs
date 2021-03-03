using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TriangleSolver
    {
        public string Analyze(int p1, int p2, int p3)
        {
            bool isTriangle;
            string shape;
            if (p1 + p2 <= p3 || p1 + p3 <= p2 || p2 + p3 <= p1)
            {
                isTriangle = false;
            }
            else
            {
                isTriangle = true;
            }

            if (p1 == p2 && p2 == p3)
            {
                shape = "Equilateral";
            }
            else if (p1 == p2 || p2 == p3 || p3 == p1)
            {
                shape = "Isoceles";
            }
            else
            {
                shape = "Scalene";
            }

            if(isTriangle)
            {
                return "It is a triangle and the triangle is " + shape;
            }
            else
            {
                return "It is not a triangle";
            }
        }
    }
}