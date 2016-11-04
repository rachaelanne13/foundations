// (The Title of this implies it is using a method, but it's actually using a function)

// This program creates a random array of 5 single digit numbers, then asks the user to guess it
// I had to use a few new things to create it.
// Random was easy to understand since it's not that different from what I've done in Python with the random library
// But the others are a bit more confusing. I'm not going to delve too deeply into them right now
// Because I don't want to get too far off track from the class.
// So for now I am just considering them MAGIC

using System;
using System.Linq;


class Homework4Optional3AsGame
{
    static int[] Compare(int[] guess, int[] target)
    {
        // initialize a comparison array
        int i = 0;
        int[] compare_array = new int[guess.Length];

        // build comparison array by comparing user's guess with target
        foreach (int x in guess)
        {
            if (x == target[i])
            {
                compare_array[i] = x;
                i++;
            }
            else
            {
                compare_array[i] = 0;
                i++;
            }
        }
        return compare_array;
    }
    static void Main()
    {

        //Initiate target array from random values
        int Min = 1;
        int Max = 9;

        int[] target = new int[5];
        Random randNum = new Random();
        for (int i = 0; i < target.Length; i++)
        {
            target[i] = randNum.Next(Min, Max);
        }

        //Explain the rules of the game to the user
        Console.WriteLine("Let's play a game!");
        Console.WriteLine("I have a list of numbers.");
        Console.WriteLine("But I'm not going to tell you the numbers! Can you figure it out?");
        Console.WriteLine("Give me a list of 5 single digit numbers without commas or spaces (eg '12345') and I'll show you which ones are correct.");
        Console.WriteLine("If it says 0, you got it wrong. Note! Value must be in correct place to be shown, otherwise they will return as 0 even if they are in the list");
        Console.WriteLine("For example, if my list is 12345 and you guess 13542, I will return 10000 to you, as 1 was the only number in the correct location");


        // Start the game loop
        bool HaveAnswer = false;
        int guessCount = 0;
        while (HaveAnswer == false)
        {
            // Ask the user for a guess
            Console.Write("\n" + "Guess:  ");
            string userInput = Console.ReadLine();

            // Convert the guess to an array
            int[] userGuess = userInput.Select(c => c - '0').ToArray(); // magically converts a string of integers to an array


            // build comparison array by comparing user's guess with target
            int[] compare_array = Compare(target, userGuess);

            // Write the comparison array to the user
            foreach (int x in compare_array)
            {
                Console.Write(x);
            }
            guessCount++;

            // Evaluate to see if guess is correct
            bool isEqual = Enumerable.SequenceEqual(compare_array, target); // magically evaluates if the contents of the two arrays are equal
            if (isEqual)
            {
                // For a correct guess, return congrats + guess count to user
                Console.WriteLine("\n" + "You got it! It took you {0} tries", guessCount);
                HaveAnswer = true;
            }

        }
        Console.ReadLine(); // Hold on screen.
    }
}