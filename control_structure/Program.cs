using System;

class ControlStructures
{
    static void Main()
    {
        // If-else control structure
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Switch-case control structure
        char grade = 'B';
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Good job!");
                break;
            case 'C':
                Console.WriteLine("Passing grade.");
                break;
            default:
                Console.WriteLine("Invalid grade.");
                break;
        }

        // For loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("For loop iteration: " + i);
        }

        // While loop
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("While loop iteration: " + count);
            count++;
        }

        // Do-while loop
        int num = 5;
        do
        {
            Console.WriteLine("Do-While loop iteration: " + num);
            num--;
        } while (num > 0);

        // Basic array operations
        int[] numbersArray = { 1, 2, 3, 4, 5 };

        // Array iteration using for loop
        Console.WriteLine("Accessing array elements using for loop:");
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write(numbersArray[i] + " ");
        }
        Console.WriteLine();

        // Array iteration using foreach loop
        Console.WriteLine("Accessing array elements using foreach loop:");
        foreach (int numb in numbersArray)
        {
            Console.Write(numb + " ");
        }
        Console.WriteLine();
    }
}
