using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {  
            /////////SQUARE object ////////////
            Square mySquare = new Square();
            mySquare.Side = 10;
            Console.WriteLine("Square Area:" + mySquare.CalculateArea());
            Console.WriteLine("Square Perimeter :" + mySquare.CalculatePerimeter());

            //////RECTANGLE object ///////////
            Rectangle myRectangle = new Rectangle();
            myRectangle.SideA = 10;
            myRectangle.SideB = 5;
            Console.WriteLine("Rectangle area :" + " " +myRectangle.CalculateArea());
            Console.WriteLine("Rectangle perimeter: "+ " "+ myRectangle.CalculatePerimter());
            Console.WriteLine("Rectangle diagonal:" + " " +myRectangle.CalculateDiagonal());

            ///////////Print N times//////////////////
            Console.WriteLine("Enter intiger number n: ");
            int nPrints = int.Parse(Console.ReadLine());
            PrintArea(myRectangle, nPrints);

            /////////Find Bigger Perimeter ///////////
            BiggerPerimeter(myRectangle , mySquare);

            Console.ReadLine();
        }


        public static void PrintArea(Rectangle rectangle, int nPrints)
        {   
            for (int i = 0; i < nPrints; i++)
            {
                Console.WriteLine("This print N times: " + " " +rectangle.CalculateArea());
            }
        }

        public static void  BiggerPerimeter (Rectangle rectangle, Square square)
        {
            if (rectangle.CalculatePerimter() > square.CalculatePerimeter())
            {
                Console.WriteLine("Rectangle perimeter is bigger");
            }
            else
            {
                Console.WriteLine("Square perimeter is bigger");
            }
        }
    }

}




