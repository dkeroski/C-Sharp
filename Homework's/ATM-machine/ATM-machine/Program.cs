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
            int amount = 20000;
            int pin, deposit = 0, withdraw = 0, choice;


            do
            {
                Console.WriteLine("Please enter your PIN:");
                string input = Console.ReadLine();
                pin = int.Parse(input);
            } while (pin != 1234);

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
                    checkCash(withdraw, amount);
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
                Console.Clear();
                atmMachine();
            }
        }

        private static void checkCash(int withdraw, int amount)
        {
            int moneyLeft = amount - withdraw;
            int[] banknotes = new int[] { 10, 50, 100, 500, 1000, 5000 };
            int[] quantity = new int[] { 20, 10, 10, 2, 8, 10 };
            int[] BanknotesGiven = new int[6];
            if (withdraw > amount)
            {
                Console.WriteLine("Not enough money in your account:");
                Console.ReadLine();
            }
            else
            {
                int i = banknotes.Length - 1;
                while (withdraw > 0)
                {
                    if (banknotes[i] > withdraw)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        if (quantity[i] > 0)
                        {
                            withdraw -= banknotes[i];
                            amount -= banknotes[i];
                            quantity[i]--;
                            BanknotesGiven[i]++;
                        }
                        else
                            i--;
                    }

                }

                Console.WriteLine("Your current balance is:" + amount);
                Console.WriteLine("Dadeni banknoti: ");
                for (int j = 0; j < BanknotesGiven.Length; j++)
                {
                    if (BanknotesGiven[j] == 0)
                        continue;
                    else
                    {
                        Console.WriteLine("{0} : {1}", banknotes[j], BanknotesGiven[j]);
                    }



                }


                //throw new NotImplementedException();

            }
        }
    }
}
