using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] bankAccount =
            {
                {"Dann", "12000", "dann123"},
                {"David", "6500", "david123"},
                {"James", "23000", "james123"},
                {"Mark", "97658", "mark123"},
                {"Anne", "123456", "anne123"}
            };

            bool bankTransaction = true;

            while (bankTransaction)
            {
                Console.WriteLine("BANKING STATION");
                Console.WriteLine();
                Console.Write("Enter Account Name: ");
                String accountName = Console.ReadLine();
                Console.Write("Enter PIN: ");
                String bankPassword = (Console.ReadLine());
                bool AccountFound = false;

                for (int i = 0; i < bankAccount.GetLength(0); i++)
                {
                    if (accountName == bankAccount[i, 0])
                    {
                        if (bankPassword == bankAccount[i, 2])
                        {
                            double money = Convert.ToDouble(bankAccount[i, 1]);
                            Console.Clear();
                            Console.WriteLine($"Welcome {bankAccount[i, 0]}! \n [1] Withdraw \n [2] Deposit \n [3] Check Balance \n");
                            Console.Write("Choose your transaction: ");
                            int transaction = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (transaction)
                            {
                                case 1:
                                    Console.WriteLine("WITHDRAW");
                                    Console.WriteLine($"Your current balance is {bankAccount[i, 1]}");
                                    for (int x = 0; x < 1; x--)
                                    {
                                        Console.Write("Withdraw Amount: ");
                                        double withdraw = double.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        if (withdraw <= 20000)
                                        {
                                            if (withdraw <= money)
                                            {
                                                money -= withdraw;
                                                bankAccount[i, 1] = Convert.ToString(money);
                                                Console.WriteLine($"Your new balance is {bankAccount[i, 1]}");
                                                break;
                                            }
                                            else Console.WriteLine("You don't have enough money");
                                        }
                                        else Console.WriteLine("Please try again, the limit is 20,000");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("DEPOSIT");
                                    Console.WriteLine($"Your current balance is {bankAccount[i, 1]}");
                                    Console.Write("How much would you like to deposit: ");
                                    double deposit = double.Parse(Console.ReadLine());
                                    money += deposit;
                                    bankAccount[i, 1] = Convert.ToString(money);
                                    Console.WriteLine($"Your new balance is {bankAccount[i, 1]}");
                                    break;
                                case 3:
                                    Console.WriteLine("BALANCE CHECK");
                                    Console.WriteLine($"Your current balance is {bankAccount[i, 1]}");
                                    break;

                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (!AccountFound)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid. Please Try Again");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
