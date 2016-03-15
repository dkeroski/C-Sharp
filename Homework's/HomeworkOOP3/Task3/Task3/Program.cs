using Interfaces;
using Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICalculable> calcuableList = new List<ICalculable>();

            Square square = new Square();
            square.Side = 10;
            square.CalculatePerimeter();
            square.CalculateArea();

            Rectangle rectangle = new Rectangle();
            rectangle.SideA = 10;
            rectangle.SideB = 20;
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();

            calcuableList.Add(square);
            calcuableList.Add(rectangle);
            foreach (var item in calcuableList)
            {
                Console.WriteLine("Area for :"+ item.Area);
                Console.WriteLine("Perimter for :"+ item.Perimeter);
            }
   
            Console.ReadLine();
        }
    }
}
