using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            atmMachine();
        }

        static void atmMachine()
        {
            int amount = 12000;
            int pin, deposit = 0, withdraw = 0, choice;


            Console.Write("Please enter your PIN:");
            pin = int.Parse(Console.ReadLine());
            if (pin != 1234)
            {
                Console.Write("PIN not match , Please enter your PIN:");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("****************Welcome to ATM Service**************");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quit");
                Console.WriteLine("****************************************************");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your current balance is :" + amount);
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount to withdraw :");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("Enter withdraw divisible by 100 denars :");
                            Console.ReadLine();
                        }

                        else if (withdraw > amount)
                        {
                            Console.WriteLine("Not enough money in your account:");
                        }
                        else
                        {
                            amount -= withdraw;
                            Console.WriteLine("Please collect your cash!");
                            Console.WriteLine("Your current balance is:" + amount);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Please enter your amount of deposit!");
                        deposit = int.Parse(Console.ReadLine());
                        amount += deposit;
                        Console.WriteLine("Your current balance is :" + amount);
                        break;

                    case 4:
                        Console.WriteLine("Thanks for used ATM machine");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again!");
                        break;

                }

                Console.WriteLine("Do you wish to have a new transaction? ( y / n) :");
                string transaction = (Console.ReadLine());
                while (!((transaction[0] != 'n') || (transaction[0] != 'y')))
                {
                    transaction = Console.ReadLine();
                }

                if (transaction[0] == 'n')
                {
                    Console.WriteLine("Thanks for used ATM machine , Goodbye....");
                    Console.ReadLine();
                }

                else if (transaction[0] == 'y')
                {
                    atmMachine();
                }
            }

        }
    }
}
