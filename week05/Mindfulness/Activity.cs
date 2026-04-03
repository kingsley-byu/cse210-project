using System;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);

        Console.Write("What duration would you like to take the activity?");
        int duration = int.Parse(Console.ReadLine());
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job,  Well Done!!");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 4; i>0; i--)
        {
            Console.Write("..");
            Thread.Sleep(1000);
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(15);
        Thread.Sleep(1000);

        while (DateTime.Now < endTime)
        {
           Console.WriteLine("Done✅"); 
        }

    }
}