using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Square
    {
        public double Side { get; set; }

        public double CalculateArea()
        {
            var area =Math.Pow(Side , 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            var perimeter = 4 * Side;
            return perimeter;
        }

       



    }

    


}
