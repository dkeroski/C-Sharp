using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //printNumbersAscending();
            //printNumbersDescending();
            //printEvenNumbers();
            //printOddNumbers();
             breakForLoop();


        }

        //static void printNumbersAscending()
        //{

        //    Console.WriteLine("Please enter a positive number: ");
        //    int userInput = int.Parse(Console.ReadLine());
        //    int i = 1;
        //    while (i < userInput)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        //        Console.ReadLine();
        //}


        ////////////////////////////////////

        //static void printNumbersDescending()
        //{
        //    Console.WriteLine("Please enter a positive number: ");
        //    int userInput = int.Parse(Console.ReadLine());
        //    int i = userInput;

        //    while (i <= userInput)
        //    {
        //        Console.WriteLine(i);
        //        i--;
        //    }
        //    Console.ReadLine();
        //}

        ////////////////////////////////////

        //static void printEvenNumbers()
        //{
        //    Console.WriteLine("Please enter a positive number: ");
        //    int userInput = int.Parse(Console.ReadLine());
        //    int i = 2;
        //    while (i <= userInput)
        //    {
        //        if (i % 2  == 0)
        //        Console.WriteLine(i);
        //        i++;
        //    }
        //    Console.ReadLine();
        //}


        //static void printOddNumbers()
        //{
        //    Console.WriteLine("Please enter a positive number: ");
        //    int userInput = int.Parse(Console.ReadLine());
        //    int i = 1;
        //    while (i <= userInput)
        //    {
        //        Console.WriteLine(i);
        //        i += 2;
        //    }
        //    Console.ReadLine();
        //}

        static void breakForLoop()
        {
            {
                int x = 1;
                do
                {
                   Console.WriteLine(x);
                   x++;
                } while (x <= 7);
                Console.ReadLine();
            }
        }
    }
}

