using System;

struct InventoryItem
{
    public int itemID;
    public string itemDescript;
    public double pricePerItem;
    public int quantityOnHand;
    public double ourCostPer;
    public double itemValue;
}


class Inventory
{
    public static void Main()
    {
        // Keep track of # of items in Inventory 
        int numberOfItems = 0;

        // Array to store structs in
        // I'll set it  to hold 100 items

        var Items = new InventoryItem[100];

        // While loop to keep programming running as long as user doesn't specific quit
        bool running = true;
        while (running)
        {
            // Display the options to the user
            Console.WriteLine("");
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("Choose from the following options: ");
            Console.WriteLine("1. Add an item." + "\n" + "2. Change an item" + "\n" + "3. Delete an item" + "\n" + "4. List all items" + "\n" + "5. Quit");
            Console.Write("Enter # of desired task: ");
       

            // Store the user's choice to a variable and convert to int
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            Console.WriteLine("");

            // Switch for selecting the appropriate case
            switch (userChoice)
            {
                case 1:
                    // Get values from user.
                    Console.Write("What is the item?:  ");
                    string uitemDescipt = Console.ReadLine();

                    Console.Write("What is the item ID?:  ");
                    string suitemID = Console.ReadLine();
                    int uItemID = int.Parse(suitemID);

                    Console.Write("Price per item:  ");
                    string sPricePerItem = Console.ReadLine();
                    double uPricePerItem = double.Parse(sPricePerItem);

                    Console.Write("Quantity: ");
                    string sQuantityOnHand = Console.ReadLine();
                    int uQuantityOnHand = int.Parse(sQuantityOnHand);

                    Console.Write("Our cost per item:  ");
                    string sOurCostPer = Console.ReadLine();
                    double uOurCostPer = double.Parse(sOurCostPer);

                    // Assign the inputs to the struct
                    Items[numberOfItems].itemID = uItemID;
                    Items[numberOfItems].itemDescript = uitemDescipt;
                    Items[numberOfItems].pricePerItem = uPricePerItem;
                    Items[numberOfItems].quantityOnHand = uQuantityOnHand;
                    Items[numberOfItems].ourCostPer = uOurCostPer;
                    Items[numberOfItems].itemValue = uOurCostPer * uQuantityOnHand;

                    // Increase the inventory item counter
                    numberOfItems++;

                    break;

                case 2: // Change an entry
                        // Ask the User to Select an ID number
                    Console.WriteLine("Please enter the Inventory ID of the item you wish to change:  ");
                    string sUserSelect = Console.ReadLine();
                    int userSelect = int.Parse(sUserSelect);
                    // Find the item, making sure it's a valid ID number!
                    bool idfound = false;
                    for (int x = 0; x <= numberOfItems; x++)
                    {
                        if (Items[x].itemID == userSelect)
                        {

                            // Get all the new values
                            Console.Write("What is the item?:  ");
                            string newDescript = Console.ReadLine();

                            Console.Write("What is the item ID?:  ");
                            string newId = Console.ReadLine();
                            int uNewID = int.Parse(newId);

                            Console.Write("Price per item:  ");
                            string nsPricePerItem = Console.ReadLine();
                            double nuPricePerItem = double.Parse(nsPricePerItem);

                            Console.Write("Quantity: ");
                            string nsQuantityOnHand = Console.ReadLine();
                            int nuQuantityOnHand = int.Parse(nsQuantityOnHand);

                            Console.Write("Our cost per item:  ");
                            string nsOurCostPer = Console.ReadLine();
                            double nuOurCostPer = double.Parse(nsOurCostPer);

                            // Change the values to the new ones

                            Items[x].itemID = uNewID;
                            Items[x].itemDescript = newDescript;
                            Items[x].pricePerItem = nuPricePerItem;
                            Items[x].quantityOnHand = nuQuantityOnHand;
                            Items[x].ourCostPer = nuOurCostPer;
                            Items[x].itemValue = nuQuantityOnHand * nuOurCostPer;

                            idfound = true;

                        }

                        if (idfound == false)
                        {
                            Console.Write("{0} is not a valid ID number.", sUserSelect);
                        }
                        
                    }
                    break;
                case 3:
                    // Ask the user which item to delete
                    Console.WriteLine("Enter the ID number of the Item you wish to delete");
                    string suserToDelete = Console.ReadLine();
                    int userToDelete = int.Parse(suserToDelete);
                    bool isDeleted = false;

                    for (int x = 0; x <= numberOfItems; x++)
                    {
                        if (Items[x].itemID == userToDelete)
                        {
                            isDeleted = true;
                            for (var ind = x; ind < numberOfItems; ind++)
                            {
                                Items[ind] = Items[ind + 1];

                            }
                            numberOfItems--;

                        }
                    }

                    if (isDeleted == false)
                    {
                        Console.WriteLine("{0} is not a valid ID number", suserToDelete);
                    }
                    break;
                case 4: // List all Items


                    Console.WriteLine("ItemID  Description           Price  QOH  Cost  Value");
                    Console.WriteLine("------  --------------------  -----  ---  ----  -----");
                    for (int x = 0; x < numberOfItems; x++)
                    { 
                            Console.WriteLine("{0, 6}  {1,20}  {2, 6}  {3, 3}  {4, 4}  {5, 4}", Items[x].itemID, Items[x].itemDescript, Items[x].pricePerItem, Items[x].quantityOnHand, Items[x].ourCostPer, Items[x].itemValue);
                        
                    }
                    
                    break;

                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to leave the program? (hit 'n' to keep running:  ");
                        string userDecision = Console.ReadLine();

                        if (userDecision == "n")
                        {
                            userChoice = 0;   
                        }

                        else
                        {
                            running = false;
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("{0} is an invalid option, please try again", userChoice);
                        break;
                    }





            }
                   

                         
            }
        }
    }
