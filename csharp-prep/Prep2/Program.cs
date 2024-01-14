using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Grade: ");
        string strGrade = Console.ReadLine();
        int numGrade = int.Parse(strGrade);

        Console.WriteLine($"You entered: {numGrade}");

        if(numGrade >=90)
        {
            string gSign = getSign(numGrade);

            Console.WriteLine("Your Grade in Letter is A" + gSign);
        }
        else if(numGrade >= 80)
        {
            string gSign = getSign(numGrade);
            Console.WriteLine ("B" + gSign);
        }
        else if(numGrade >=70)
        {
            string gSign = getSign(numGrade);
            Console.WriteLine("C" + gSign);
        }
        else if(numGrade >=60)
        {
            string gSign = getSign(numGrade);
            Console.WriteLine("D" + gSign);
        }
       else if(numGrade < 60)
       {
            Console.WriteLine("Failed");
       }

    }
    //Function to get Grade Sign
    public static String getSign(int nGrade)
{
    int lastDigit = nGrade % 10;
    if (lastDigit >= 7)
    {
        return "+";
    }
    else if (lastDigit <= 3)
    {
        return "-";
    }
    else
    {
        return ""; // return an empty string or some default value for other cases
    }
}

}