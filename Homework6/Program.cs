using System;

namespace ConsoleApplication1
{
    // Struct to store information about the pets
    public struct Pet
    {
        public string Name;
        public string TypeofPet;
    }

    class Program
    {
        static void Main()
        {
            // Set the number of pets to 0 and create a new stuct
            var numberofPets = 0;
            // This struct will accept only up to 10 pets! Any more will throw an index out of range exception
            var pets = new Pet[10];

            while(true) // Holds the menu up so user can keep selecting options
            {
                // Give the user options for what to do and save their response to a variable
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();

                // Use switch to process user input
                switch (choice)
                {
                    case "A": // If the user chooses to add a Pet
                    case "a": // to make sure it's not case sensitive
                        {
                            // Ask the user for the name and type of pet, store the responses in variables
                            Console.Write("Name: ");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet : ");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end
                            pets[numberofPets].Name = name;
                            pets[numberofPets].TypeofPet = typeOfPet;

                            // Increase number of pets as we now have a new one
                            numberofPets++;
                            break;
                        }
                    case "D": // If the user chooses to delete a Pet
                    case "d": // to make sure it's not case sensitive
                        {
                            // First check to see if there is even a pet to delete!
                            // If not, inform them.
                            if (numberofPets == 0)
                            {
                                Console.WriteLine("No pets");
                                break;

                            }
                            // Now we will print out all the pets currently in the struct and assign them a number
                            // The user will be able to select a pet by number.
                            for (var index = 0; index < numberofPets; index++)
                            {
                                // The index must be increased by 1 because it starts at 0 but we will want to display it starting @ 1
                                Console.WriteLine("{0}.{1, -10}{2}", index + 1, pets[index].Name, pets[index].TypeofPet);

                            }
                            // Ask the user to select a number corresponding to the pet they want to delete
                            Console.Write("Which Pet to remove(1-{0}", numberofPets);

                            // Store the input and convert to integer type
                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);

                            // Squish the array from index to delete to the end. 
                            // Subtract one from index because now we need to fix the index increment earlier

                            for (var index = indexToDelete - 1; index < numberofPets; index++)
                            {
                                // Just copy the pet from the next index in the current index
                                pets[index] = pets[index + 1];
                            }
                                // Deincrement the pets. We have one less pet :( 
                                numberofPets--;

                                break;

                            
                        }

                    case "L": // For when the user chooses to list all current pets
                    case "l": // To make sure its not case sensitive
                        {
                            // First check to see if there are even any pets to list!
                            // If not, inform them. 
                            if (numberofPets == 0)
                            {
                                Console.WriteLine("No Pets");
                            }

                            // Use a for loop to print off each pet in the struct and the corresponding string values assigned to them
                            for (int index = 0; index < numberofPets; index++)
                            {
                                Console.WriteLine("{0}. {1, -10} {2}", index + 1, pets[index].Name, pets[index].TypeofPet);
                            }

                            break;
                        }
                    default:
                        // Include an error message if the option the user chooses is not one of the available ones
                        {
                            Console.WriteLine("Invalid Option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}