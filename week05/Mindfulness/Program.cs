using System;

class Program
{

    // Additional Activity: VisualizationActivity was added as a creative fourth option.
    // It randomly selects a peaceful scene and guides the user through it
    // with descriptive lines until the duration expires.
    static void Main(string[] args)
    {
        ActivityMenu menu = new ActivityMenu();
        menu.Run();
    }
}