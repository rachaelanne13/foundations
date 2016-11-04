// Create an array of 5 random numbers 
// Ask the user to guess values of the array
// Return values of array with 0 or correct guesses
// Continue until user has guessed all
// Display final array once all guessed along with number of times it took to get there
using System;
using System.Linq;

class CompareGuess //takes the user array and compares it to the target array
{
   
    public int[] Compare(int[]guess, int[]target)
    {
        // initialize a comparison array
        int i = 0;
        int[] compare_array = new int [guess.Length];

        // build comparison array by comparing user's guess with target
        foreach(int x in guess)
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
}
class Homework4Optional3AsGame
{
    static void Main()
    {
        //Initiate CompareGuess class
        CompareGuess cg = new CompareGuess();

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
        Console.WriteLine("If it says 0, you got it wrong. Note! Value must be in correct place to be shown.");

        // Start the game loop
        bool HaveAnswer = false;
        int guessCount = 0;
        while (HaveAnswer == false)
        {
            // Ask the user for a guess
            Console.Write("\n" + "Guess:  ");
            string userInput = Console.ReadLine();

            // Convert the guess to an array
            int[] userGuess = userInput.Select(c => c - '0').ToArray();

            // Compare guess array to target array. This returns an array of correct/incorrect guesses
            int[] compare_array = cg.Compare(userGuess, target);
            foreach(int x in compare_array)
            {
                Console.Write(x);
            }
            guessCount++;

            // Evaluate to see if guess is correct
            bool isEqual = Enumerable.SequenceEqual(compare_array, target);
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
