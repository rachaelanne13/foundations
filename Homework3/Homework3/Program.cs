//Write a program that calculates factorial of an integer n given by the user.  Please enter a small integer.
//--so calculate a factorial of only a small integer and give error if it's larger than something?

using System;

class homework3
{
    static void Main()
    {
        //Ask the user to input a number
        Console.Write("Input a number lower than 20 to calculate its factorial: ");

        // Store the value 
        string userInput = Console.ReadLine();

        //Convert value to an integer
        int userInteger = int.Parse(userInput);

        //Evaluate to see if integer is small
        if (userInteger < 20)
            {
            //Calculate factorial using a for loop
            int factorial = 0;
            int x;
            for (x = 1; x < userInteger; x++)
            {
                int newValue = userInteger * x;
                factorial = factorial + newValue;
            }
            Console.WriteLine("The factorial of {0} is {1}", userInteger, factorial);
        }
        else
        {
            Console.WriteLine("{0} is not less than 20!", userInteger);
        }


        Console.ReadLine(); //hold on screen
    }
}
