// Definition: The factorial of an integer n, written n!, is the product of the consecutive integers 1 through n.  
//For example, 5 factorial is calculated as: 5! = 5 x 4 x 3 x 2 x 1 = 120.

// Write a program that allows the user to enter the number of factorials to display

// Dan: I'm not sure if I made this more complicated than it needed to be. I worked on this
// last week and was struggling with getting it to work because my code was getting so messy.
// After the lecture on classes, I realized I could do it this way, but if there's a more elegant way to get it work
// in just one class, I would appreciate advice! 

using System;
class Factorial // Class that calculates factorial from given number.
{
    public int CalculateFactorial(int number)
    {
        // Initialize 
        int i;
        int[] numbers = new int[number];

        // Create an array 
        for (i = 0; i < number; i++)
        {
            numbers[i] = number - i;
        }

        // Calculate factorial & return it.
        int factorial = 1;
        foreach(int x in numbers)
        {
            factorial = factorial + (x * factorial);
        }
        return factorial;
        }
    }

class Homework4
{
    static void Main()
    {
        // Ask the user to input a value.
        Console.Write("How many factorials should I display?: ");

        // Assign input to variable & convert to int.
        string userInput = Console.ReadLine();
        int userValue = int.Parse(userInput);

        // Initialize the Factorial class
        Factorial f = new global::Factorial(); // Why did it add global? 

        // Create an array.
        int i;
        int[] array = new int[userValue];
        for(i = 0; i < userValue; i++)
        {
            array[i] = i + 1;
        }
        // Create new array to populate using array. 
        int[] array2 = new int[userValue];

        // Repopulate the array by using CalculateFactorial.
        foreach(int x in array)
        {
            array2[x - 1] = f.CalculateFactorial(x);
            // Return to user.
            Console.Write(("{0, 3}! = {1, 3}" + "\n"), x, array2[x -1]);
        }

        Console.ReadLine(); //Hold ouput on screen.

        
    }
}