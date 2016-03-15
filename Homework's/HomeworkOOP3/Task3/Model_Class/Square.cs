using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Class
{
    public class Square : ICalculable
    {
        public int Side { get; set; }

        public int Area { get; set; }
        public int Perimeter { get; set; }


        public int CalculateArea()
        {
            return Area = Side * Side;
        }
        public int CalculatePerimeter()
        {
            return Perimeter = Side * 4;
        }
    }
}
