using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("14 April 2026", 30, 3.0));
        activities.Add(new CyclingActivity("14 April 2026", 30, 8.7));
        activities.Add(new SwimmingActivity("14 April 2026", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}