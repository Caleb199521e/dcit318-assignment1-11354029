using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Triangle Type Identifier!");

        // Ask for the first side
        Console.Write("Enter the length of the first side: ");
        int side1 = int.Parse(Console.ReadLine());

        // Ask for the second side
        Console.Write("Enter the length of the second side: ");
        int side2 = int.Parse(Console.ReadLine());

        // Ask for the third side
        Console.Write("Enter the length of the third side: ");
        int side3 = int.Parse(Console.ReadLine());

        // Check if it's a valid triangle first
        bool isValid = (side1 + side2 > side3) &&
                       (side1 + side3 > side2) &&
                       (side2 + side3 > side1);

        if (!isValid)
        {
            Console.WriteLine("These sides do not form a valid triangle.");
        }
        else
        {
            // Check for triangle type
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
