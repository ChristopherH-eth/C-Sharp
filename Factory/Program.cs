// Account Factory Program
// Version 1.0
//
// Christopher Hardy
// POS/409
// February 1st, 2016
// Lynn Thackeray
//
// Description:
// The Account Factory Program utilizes the Factory design pattern along with Reflection to allow the user to create
// select types of bank accounts.  A switch statement is used to ensure the user is only selecting from valid types, and
// the factory class checks for the corresponding type to display a message based on the type selected by the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RUNNING = true;

            Console.WriteLine("Welcome to the Account Factory Program! \n\nBy using this program, you will be able" +
                "to create very simple bank accounts through the selection of options provided.");

            // While loop for user input/account creation
            while (RUNNING)
            {
                Console.WriteLine("\nEnter '1' for checking, '2' for savings, '3' for retirement, or '0' to exit: ");

                string input = Console.ReadLine();

                // Exception handling for non-integer input
                try
                {
                    int choice = Int32.Parse(input);

                    // Switch block to handle user input
                    switch (choice)
                    {
                        case 1:
                            var checking = AccountFactory.CreateAccount("CheckingAccount");
                            Console.WriteLine(string.Format("\nMessage from account management: {0}", checking.message));
                            break;

                        case 2:
                            var savings = AccountFactory.CreateAccount("SavingsAccount");
                            Console.WriteLine(string.Format("\nMessage from account management: {0}", savings.message));
                            break;

                        case 3:
                            var retirement = AccountFactory.CreateAccount("RetirementAccount");
                            Console.WriteLine(string.Format("\nMessage from account management: {0}", retirement.message));
                            break;

                        case 0:
                            RUNNING = false;
                            Console.WriteLine("\nThank you for using the Account Factory Program! " +
                                "\nPress 'Enter' key to exit.");
                            Console.Read();
                            break;

                        default:
                            Console.WriteLine("Invalid Input.");
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }
    }

    // IAccount interface
    public interface IAccount
    {
        string message { get; }
    }

    // CheckingAccount class
    public class CheckingAccount : IAccount
    {
        private string _message;

        public string message
        {
            get { return _message; }
        }

        public CheckingAccount()
        {
            this._message = "Checking Account Created";
        }
    }

    // SavingsAccount class
    public class SavingsAccount : IAccount
    {
        private string _message;

        public string message
        {
            get { return _message; }
        }

        public SavingsAccount()
        {
            this._message = "Savings Account Created";
        }
    }

    // RetirementAccount class
    public class RetirementAccount : IAccount
    {
        private string _message;

        public string message
        {
            get { return _message; }
        }

        public RetirementAccount()
        {
            this._message = "Retirement Account Created";
        }
    }

    // AccountFactory class
    public static class AccountFactory
    {
        public static IAccount CreateAccount(string account)
        {
            var accountType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.Name.Equals(account)).FirstOrDefault();

            var newAccount = (IAccount)Activator.CreateInstance(accountType);

            return newAccount;
        }
    }
}
