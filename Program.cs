using System;

namespace miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 See Your Balance
            // 2- Withdraw your money
            // 3- Deposit money
            // 4- Quit
           

            int balance = 800;

            Console.WriteLine("Welcome To ATM");
            Console.WriteLine("Select What You Want To Do");
            Console.WriteLine("1- See Your Balance");
            Console.WriteLine("2- Withdraw Your Money");
            Console.WriteLine("3-Deposite Your Money");
            Console.WriteLine("4- Quit");

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Your balance : " + balance);
                    Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("Enter the amount you want to withdraw");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("You cannot withdraw more than your balance.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your remaining balance :" + (balance - withdraw));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter the amount you want to deposit");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your new balance :" + (balance + deposite));
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("Logging out of your account... Have a nice day");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please click on a valid option...");
                    Console.ReadLine();
                    break;


            }
        }
    }
}

