using System;

public class Program
{
    public static void Main()
    {
        string word;

        do
        {
            Console.Clear(); // Clear the console

            Console.WriteLine("Please enter a word (type 'exit' to quit): ");

            // Take user input
            word = Console.ReadLine();

            // Check if the user wants to exit
            if (word.ToLower() == "exit")
            {
                break; // Exit the loop if the user types 'exit'
            }

            // Convert the word to a char array
            char[] charArray = word.ToCharArray();

            // Reverse the char array
            Array.Reverse(charArray);

            // Create a new string from the reversed char array
            string reversedWord = new string(charArray);

            // Check if the reversed word is the same as the original word  
            bool isPalindrome = string.Equals(word, reversedWord, StringComparison.OrdinalIgnoreCase);

            if (isPalindrome)
            {
                Console.WriteLine($"The word '{word}' is a palindrome!");
            }
            else
            {
                Console.WriteLine($"The word '{word}' is not a palindrome. The Reversed word is {reversedWord}");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine(); // Wait for user to press Enter before continuing
        } while (word.ToLower() != "exit"); // Check if the word is 'exit' to exit the loop
    }
}
