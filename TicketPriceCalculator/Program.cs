using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Ticket Price Calculator!");

        // Ask the user to enter their age
        Console.Write("Please enter your age: ");
        
        // Read the input as a string
        string input = Console.ReadLine();

        // Convert the input to an integer
        int age = int.Parse(input); // assumes valid number is entered

        // Declare a variable to hold the ticket price
        int ticketPrice;

        // Apply the discount based on age
        if (age <= 12 || age >= 65)
        {
            // Children and senior citizens get a discount
            ticketPrice = 7;
        }
        else
        {
            // All other customers pay full price
            ticketPrice = 10;
        }

        // Display the final ticket price
        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}
