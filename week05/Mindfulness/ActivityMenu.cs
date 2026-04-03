using System;
public class ActivityMenu
{
    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness program!");
        Console.WriteLine("Please choose an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("1. Reflecting Activity");
        Console.WriteLine("1. Listing Activity");
    }
    public void Run()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;

                case "2":
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.Run();
                break;

                case "3":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
            }
        }
    }
}