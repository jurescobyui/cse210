using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //task assignment point 1 and point 2
       // Console.Write("What is the magic number? ");
       // int magicNumber =int.Parse(Console.ReadLine());
    //assignment point 3

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int myGuess = 0;
        // for stretch challenge track the number of tries
        int  myTries = 0;
        
        while (myGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            myGuess = int.Parse(Console.ReadLine());

            if (magicNumber > myGuess)
            {
                Console.WriteLine("Higher");
                myTries ++;
            }
            else if (magicNumber < myGuess)
            {
                Console.WriteLine("Lower");
                myTries ++;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                myTries ++;
                Console.WriteLine($"After {myTries} tries!");
            }

        }                    
       
    }
}