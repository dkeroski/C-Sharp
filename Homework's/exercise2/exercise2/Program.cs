using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //findMaxinArray();
            //diferenceMaxMin();
            //findPositionOfMin();
             palindrom();
        }

        //static void findMaxinArray()
        //{

        //    int[] myArray = new int[10] { 2, 44, 5, 6, 1, 7, 8, 9, 11, 2 };
        //    int max = myArray[0];

        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (max < myArray[i])
        //            max = myArray[i];
        //    }

        //    Console.WriteLine("The maximum of the array is : " + max);
        //    Console.ReadLine();
        //}



        //static void diferenceMaxMin()
        //{
        //    int[] myArray = new int[10] { 2, 44, 5, 6, 1, 7, 8, 9, 11, 2 };
        //    int max = myArray[0];
        //    int min = myArray[0];
        //    float diference = 0;

        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (max < myArray[i])
        //            max = myArray[i];
        //    }

        //    for (int j = 0; j < myArray.Length;  j++)
        //    {
        //        if (myArray[j] < min)
        //            min = myArray[j];
        //    }

        //    diference = max - min;
        //    Console.WriteLine("The difference between max and min is : " + diference);
        //    Console.ReadLine();
        //}


        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        if (max < myArray[i])
        //            max = myArray[i];
        //    }

        //static void findPositionOfMin()
        //{
        //    int[] array = new int[10] { 4, 3, 66, 7, 8, 9, 33, 18, 5, 90 };
        //    int min = array[0];
        //    int position = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //            min = array[i];
        //       position = Array.IndexOf(array, min);
        //    }

        //    Console.WriteLine("The min element in array is : " + min +  " on position : " + position );
        //    Console.ReadLine();
        //}

        static void palindrom()
        {
            Console.Write("PLease enter a positive integer:");
            string number = Console.ReadLine();
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            string backward = new string(array);
            if (number == backward)
            {
                Console.WriteLine("The number" + " " + number + " is palindrome");
            }
            else
            {
                Console.WriteLine("The number" + " " + number + " is not palindrome");
            }
            Console.ReadLine();
        }
    }
}
