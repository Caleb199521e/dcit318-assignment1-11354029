using System;

class Program
{
    static void Main()
    {
        // Print a welcome message
        Console.WriteLine("Welcome to the Grade Calculator!");

        // Ask the user to enter a numerical grade
        Console.Write("Please enter a grade between 0 and 100: ");
        
        // Read the user input and store it as a string
        string input = Console.ReadLine() ?? "";

        // Convert the string to an integer
        int grade = int.Parse(input); // Assumes user enters a number

        // Declare a variable to hold the letter grade
        string letterGrade;

        // Determine the letter grade using if-else statements
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Show the result
        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}
