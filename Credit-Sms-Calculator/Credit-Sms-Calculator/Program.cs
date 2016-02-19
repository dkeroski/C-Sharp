using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Sms_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            smsCalculator();
        }

        static void smsCalculator()
        {

            double credit;
            double smsCost = 2.6;
            double smsSent;
            double creditLeft;


            Console.WriteLine("Please enter your credit amount: ");
            credit = Convert.ToDouble(Console.ReadLine());

            smsSent = Math.Floor(credit / smsCost);
            Console.WriteLine("You can send : " + smsSent);

            creditLeft = (credit - smsSent * 2.6);
            Console.WriteLine("You have " + creditLeft + " credits left");
            Console.ReadLine();
        }
    }
}

