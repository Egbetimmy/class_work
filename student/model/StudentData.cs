// StudentData.cs - Handles student data
using System;
using System.Collections.Generic;

public class StudentData
{
    public static Dictionary<int, List<string>> GetStudentsWithAge(int[] studentAges, string[] studentNames)
    {
        Dictionary<int, List<string>> studentsByAge = new Dictionary<int, List<string>>();

        for (int i = 0; i < studentAges.Length; i++)
        {
            int age = studentAges[i];
            string name = studentNames[i];

            if (!studentsByAge.ContainsKey(age))
            {
                studentsByAge[age] = new List<string>();
            }

            studentsByAge[age].Add(name);
        }

        return studentsByAge;
    }
}
