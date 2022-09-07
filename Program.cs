using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Simple App
            Console.WriteLine("Welcome to Veepay");
            Console.Write("Will you like to sign up: ");
            string signup = Console.ReadLine();
            if (signup == "Yes")
            {
                Console.WriteLine("Click the button below to create an account.");
                Console.WriteLine("Input your information.");

                Console.Write("Name:  ");
                string name = Console.ReadLine();

                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.Write("Phone Number:  ");
                    string phoneNumber = Console.ReadLine();
                }
                else
                {
                    Console.Write("You are not allowed to create an account.");
                }
                Console.Write("Account Number: ");
                string acctNo = Console.ReadLine();
                Console.Write("Create a password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Account created, login to your account");
            }
            else
            {
                Console.WriteLine("Already have an account?, then Sign in now.");
                Console.Write("Email Address or Mobile Number:  ");
                string emailAddress = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Sign in");
            }
        }
    }
}
