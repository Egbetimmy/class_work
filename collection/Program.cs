/*
 using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary to store key-value pairs
        Dictionary<string, object> userDict = new Dictionary<string, object>
        {
            { "Name", "John Doe" },
            { "Age", 30 },
            { "Address", "123 Main St, City, Country" },
            { "AccountNumber", "1234567890" },
            { "Balance", 5000.00 }
        };

        // Accessing information
        Console.WriteLine("User Information:");
        foreach (var kvp in userDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
 
 */

using System;
using System.Collections;

class Program     
{
    static void Main()
    {
        // Hashtable to store key-value pairs
        Hashtable userHashtable = new Hashtable
        {
            { "Name", "Jane Smith" },
            { "Age", 25 },
            { "Address", "456 Park Ave, Town, Country" },
            { "AccountNumber", "9876543210" },
            { "Balance", 8000.00 }
        };

        // Accessing information
        Console.WriteLine("\nUser Information (Hashtable):");
        foreach (DictionaryEntry entry in userHashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}

