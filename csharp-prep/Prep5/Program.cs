using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = AskForName();
        int userNumber = FavNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static string AskForName()
        {
            Console.Write("Enter Your Name: ");
            string username = Console.ReadLine();
            return username;
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to this C# Program!");
        }

        static int FavNumber()
        {
            Console.Write("Enter Favorite Number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int num1)
        {
           int squared = num1 * num1;
            return squared;
        }

       static void DisplayResult(string username, int sqrNumber)
       {
            Console.WriteLine($"{username} the square of your favorite number is: {sqrNumber}");
       }


    }
}