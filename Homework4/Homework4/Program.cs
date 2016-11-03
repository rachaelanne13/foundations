//Definition: The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n.  
//For example, 5 factorial is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120.

//Write a program that allows the user to enter the number of factorials to display

using System;

class Homework4
{
    static void Main()
    {
        //Create a while loop to hold the program on the screen, q exits
        while (true)
            {
            //Ask the user to input a value or press q to quit
            Console.Write("Enter a value and I will calculate the Factorial. When you are finished, press 'q' to quit: ");

            //Assign input to variable
            string userinput = Console.ReadLine();

            //Implement quit conditions
            if(userinput == "q")
            {
                break;
            }
            //Otherwise convert to integer
            int userValue = int.Parse(userinput);

            //Create an array to populate
            int i;
            int[] numbers = new int[userValue];
            for (i = 0; i < userValue; i++)
            {
                numbers[i] = (userValue - i);
            }

            //Calculate factorial
            int factorial = 1;
            foreach(int x in numbers)
            {
                factorial = factorial * x;
            }

            //Return answer to user
            Console.Write("The factorial of {0} is {1}. Press enter to find another one, or q to quit.", userValue, factorial);
            Console.ReadLine();
        }

        
    }
}