using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList;
        numbersList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int numEntry = -1;
        //continually ask for a number until user enter's 0
        while(numEntry != 0)
        {
            Console.Write("Enter a Number: ");
            numEntry = int.Parse(Console.ReadLine());
            numbersList.Add(numEntry);
        }
        //compute total assignment part1
        int numSum = 0;
        int largestSoFar = -1;
        foreach( int numItem in numbersList)
        {
            numSum += numItem;
            if(numItem > largestSoFar)
            {
                largestSoFar = numItem;
            }
        }
        Console.WriteLine($"Total: {numSum}");
        float average = ((float)numSum) / numbersList.Count;
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number is: {largestSoFar}");


    }
}