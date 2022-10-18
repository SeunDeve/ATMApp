using System;
using System.ComponentModel.DataAnnotations;
using ATMApp.Domain.Entities;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //clears the console screen
            Console.Clear();
            //sets the title of the console window
            Console.Title = "My ATM App";
            //sets the text colour or the foreground colour to white
            Console.ForegroundColor = ConsoleColor.White;

            // set the welcome messagee
            Console.WriteLine("\n\n-----------Welcome to MY ATM App-----------\n\n");
            Console.WriteLine("Note: Actual ATM machine will accept and validate" +
                   " a physical ATM card, read the card number and validate it.");

            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card pin"));
            return tempUserAccount;
        }
        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking Card Number and Pin...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest branch " +
                " to unlock your account. Thank you.", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }

        internal static void WelcomeCustomer(string fullName)
        {
            Console.WriteLine($"Welcome back, {fullName}");
            Utility.PressEnterToContinue();
        }

        internal static void DisplayAppmenu()
        {
            Console.Clear();
            Console.WriteLine("------My ATM App Menu------");
            Console.WriteLine(":                         :");
            Console.WriteLine("1. Account Balance        :");
            Console.WriteLine("2. Cash Deposit           :");
            Console.WriteLine("3. Withdrawal             :");
            Console.WriteLine("4. Tansfer                :");
            Console.WriteLine("5. Transactions           :");
            Console.WriteLine("6: Logout                 :");
        }

        internal static void LogOutProgress()
        {
            Console.WriteLine("Thank you for using My ATM App.");
            Utility.PrintDotAnimation();
            Console.Clear();
        }
    }
}

