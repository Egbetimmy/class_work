// Program.cs - Main entry point
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating an array of 10 students with names and ages
        string[] studentNames = new string[] { 
            "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Isabel", "Jack" 
        };
        int[] studentAges = new int[] { 
            17, 19, 18, 20, 16, 18, 21, 17, 19, 22 
        };

        // Get students grouped by their ages
        Dictionary<int, List<string>> studentsByAge = StudentData.GetStudentsWithAge(studentAges, studentNames);

        int ageToCheck = 18;
        if (studentsByAge.TryGetValue(ageToCheck, out List<string> studentsWithAge))
        {
            Console.WriteLine($"The following students are {ageToCheck} years old:");
            foreach (string student in studentsWithAge)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine($"No student with age {ageToCheck} found in the list.");
        }
    }
}
