using System;
using System.Collections.Generic;

public class VisualizationActivity : Activity
{
    private List<string> _scenes;
    private List<string> _lines;

    public VisualizationActivity() : base("Visualization Activity", "This activity will help you visualize or imagine a peaceful mental scene step by step")
    {
        _scenes = new List<string>
        {
            "A peaceful beach at sunset",
            "A quiet forest with birds singing",
            "A calm mountain lake at dawn",
            "A cozy cabin by a fireplace on a snowy day",
            "A beautiful garden full of colorful flowers",
            "A quiet meadow with a gentle stream nearby",
            "A starry night sky in the middle of the countryside"
        };
        _lines = new List<string>
        {
            "Feel the warm sun on your face...",
            "Hear the gentle sound of water nearby...",
            "Take a deep breath of fresh air around you...",
            "Notice the beautiful colors surrounding you...",
            "Feel a gentle breeze brushing against your skin...",
            "Let your body relax completely...",
            "You are safe and at peace here...",
            "Listen to the peaceful sounds around you...",
            "Feel the tension leaving your body with every breath...",
            "You are exactly where you need to be right now...",
            "Let your mind be still and quiet...",
            "Breathe in peace and breathe out all your worries..."
        };
    }

    public string GetRandomScene()
    {
        Random random = new Random();
        int index = random.Next(0, _scenes.Count);
        return _scenes[index];

    }

    public string GetRandomLine()
    {
        Random random = new Random();
        int index = random.Next(0, _lines.Count);
        return _lines[index];

    }
    public void DisplayScene()
    {
        Console.WriteLine("Try to visualize the following scene\n");
        Console.WriteLine(GetRandomScene());

    }
    public void DisplayLine()
    {
        Console.WriteLine("Reflect on the following lines: ");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now -startTime).TotalSeconds <Duration)
      {
        Console.WriteLine(GetRandomLine());
        ShowSpinner(4);   
      }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayScene();
        ShowCountDown(6);
        DisplayLine();
        DisplayEndingMessage();
    }
}