using System;

class Program
{
    static void Main()
    {
        School school = new School("PURPLE ARCADEMY");
        DateTime closingDate = new DateTime(2023, 12, 08); // Specify the closing date

        school.AddTeacher("Mr. David");
        school.AddTeacher("Mr. Johnson");

        school.EnrollStudent(101, "Esther");
        school.EnrollStudent(102, "Tolu");
        school.EnrollStudent(103, "Rita");
        school.EnrollStudent(104, "Tbam");

        Console.WriteLine($"School Name: {school.SchoolName}");

        Console.WriteLine($"Student with ID 101: {school[101]}");
        Console.WriteLine($"Student with ID 102: {school[102]}");
        Console.WriteLine($"Student with ID 103: {school[103]}");
        Console.WriteLine($"Student with ID 104: {school[104]}");
        Console.WriteLine($"Student with ID 105: {school[105]}");

        school.RemoveStudent(104); // Removing a student with ID 101
        school.RemoveStudent(105); // Attempting to remove a non-existing student with ID 103

        school.CloseSchool("End of the academic year", closingDate);
    }
}
