using System;
using System.Collections.Generic;

public partial class School
{
    // Fields
    private string schoolName;
    private List<string> teachers;
    private Dictionary<int, string> students;

    // Properties
    public string SchoolName
    {
        get { return schoolName; }
        set { schoolName = value; }
    }

    // Constructor
    public School(string name)
    {
        schoolName = name;
        teachers = new List<string>();
        students = new Dictionary<int, string>();
    }

}
