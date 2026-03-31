using System;

public class MathsAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathsAssignment(string studentName, string topic,string textbookSection, string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problem {_problem}";
    }

}