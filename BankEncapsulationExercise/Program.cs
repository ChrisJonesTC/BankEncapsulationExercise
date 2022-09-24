using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount userAccount = new BankAccount();


            var optOne = 1;
            var optTwo = 2;
            var optThree = 3;
            var optFour = 4;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Welcome to The Federal Reserves virtual ATM!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter the name attached to your account: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + userName + ". Please enter your account password: ");
            string passworde = Console.ReadLine();
            Console.WriteLine();


            do
            {

                Console.WriteLine("Please choose an option from below: ");
                Console.WriteLine();
                Console.WriteLine($"1. Deposit ", (optOne));
                Console.WriteLine();
                Console.WriteLine($"2. Withdrawl ", (optTwo));
                Console.WriteLine();
                Console.WriteLine($"3. Account Balance ", (optThree));
                Console.WriteLine();
                Console.WriteLine($"4. Exit ", (optFour));
                Console.WriteLine();
                int userInput = int.Parse(Console.ReadLine());



                switch (userInput)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine($"How much would you like to deposit: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        userAccount.Deposit(depositAmount);
                        double userBalance = userAccount.GetBalance();
                        Console.WriteLine();
                        Console.WriteLine("Transaction completed!");
                        Console.WriteLine($"Your current balance is {userBalance,0:c}");
                        Console.WriteLine();
                        Console.Write("Would you like to continue(Y/N)? ");
                        break;


                    case 2:

                        Console.WriteLine();
                        Console.WriteLine($"How much would you like to withdrawl: ");
                        double withdrawlAmount = double.Parse(Console.ReadLine());
                        userAccount.Withdrawl(withdrawlAmount);
                        double userBalanceTwo = userAccount.GetBalance();
                        if (withdrawlAmount <= userAccount.GetBalance())
                        {
                            Console.WriteLine("Transaction completed!");
                            Console.WriteLine($"Your current balance is {userBalanceTwo,0:c}");
                            Console.WriteLine();
                            Console.Write("Would you like to continue(Y/N)? ");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Insufficient funds ");
                            Console.WriteLine();
                            Console.Write("Would you like to continue(Y/N)? ");
                        }
                        break;


                    case 3:

                        Console.WriteLine($"Your current balance is " + userAccount.GetBalance());
                        Console.WriteLine();
                        Console.Write("Would you like to continue(Y/N)? ");
                        break;

                    case 4:

                        Console.WriteLine();
                        Console.Write("Logging out! Goodbye. ");
                        break;

                    default:

                        Console.WriteLine("Invalid response");
                        Console.WriteLine();
                        Console.Write("Would you like to continue(Y/N)? ");
                        break;

                }


            } while (Console.ReadLine().ToUpper() == "Y");
            Console.ReadLine();
            Console.WriteLine("Thank You for visiting the Federal Reserves virtual money printer, goodbye!");


        }
    }

}
