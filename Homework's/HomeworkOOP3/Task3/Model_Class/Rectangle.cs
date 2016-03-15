using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Class
{
    public class Rectangle : ICalculable
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public int Area { get; set; }
        public int Perimeter { get; set; }


        public int CalculateArea()
        {
            return Area = SideA * SideB;
        }

        public int CalculatePerimeter()
        {
            return Perimeter = 2 * (SideA + SideB);
        }
    }


}
