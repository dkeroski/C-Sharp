using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public double CalculateArea()
        {
            var area = SideA * SideB;
            return area;
        }

        public double CalculatePerimter()
        {
            var perimeter = 2*(SideA + SideB);
            return perimeter;
        }

        public double CalculateDiagonal()
        {
            var diagonal = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
            return diagonal;
        }
    }
}
