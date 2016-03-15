using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArray = new ArrayList();
            myArray.Add(15);
            myArray.Add(20);
            myArray.Add(1.75d);
            myArray.Add(3.14d);
            myArray.Add("Hello");
            myArray.Add("World");

            foreach (var item in myArray)
            {
                if (item is int)
                {
                    Console.WriteLine("Print intigers: {0}", item);
                }
                else if (item is double)
                {
                    Console.WriteLine("Print double: {0}", item);
                }
                else if (item is string)
                {
                    Console.WriteLine("Ptint strings: {0}",item);
                }

            }
            Console.ReadLine();
        }
    }
}
