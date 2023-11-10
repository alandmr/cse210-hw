using System;

class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string sName, string topic, string title) : base(sName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}