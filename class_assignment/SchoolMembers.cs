using System;

public partial class School
{
    // Methods
    public void AddTeacher(string teacherName)
    {
        teachers.Add(teacherName);
        Console.WriteLine($"Teacher {teacherName} added to the school.");
    }

    public void EnrollStudent(int studentId, string studentName)
    {
        if (!students.ContainsKey(studentId))
        {
            students.Add(studentId, studentName);
            Console.WriteLine($"Student {studentName} with ID {studentId} enrolled in the school.");
        }
        else
        {
            Console.WriteLine($"Student with ID {studentId} already exists in the school.");
        }
    }

    public void RemoveStudent(int studentId)
    {
        if (students.ContainsKey(studentId))
        {
            string removedStudent = students[studentId];
            students.Remove(studentId);
            Console.WriteLine($"Student {removedStudent} with ID {studentId} is removed from the school.");
        }
        else
        {
            Console.WriteLine($"Student with ID {studentId} does not exist in the school.");
        }
    }

    // Event
    public event EventHandler<string> SchoolClosed;

    // Method to close school with a specific year
    public void CloseSchool(string reason, DateTime closingDate)
    {
        // Additional logic to check if there are ongoing classes, etc., could be implemented here.
        SchoolClosed?.Invoke(this, $"The school is closed: {reason} ({closingDate.ToString("yyyy-MM-dd")})");
        Console.WriteLine($"The school is closed: {reason} ({closingDate.ToString("yyyy-MM-dd")})");
    }
     
    // Indexer
    public string this[int studentId]
    {
        get
        {
            if (students.ContainsKey(studentId))
            {
                return students[studentId];
            }
            else
            {
                Console.WriteLine($"Student with ID {studentId} does not exist in the school.");
                return null; // or throw an exception
            }
        }
    }
}
