using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
System.IO.File.ReadAllLines();
public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }
    public void ListGoalName()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. SimpleGoal");
        Console.WriteLine("2. CheckListGoal");
        Console.WriteLine("3. EternalGoal");
        Console.WriteLine("4. Quit");

        Console.Write("Enter a goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter goal description");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("Enter point you will to assign to this goal");
        string g = Console.ReadLine();
        int  goalPoint = int.Parse(g);

        switch (choice)
        {
            case "1":
            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoint);
            _goals.Add(simple);
            break;
        }
        
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {
        Console.Write("Create a file name");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal  goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter file name:");
        string fileName = Console.ReadLine();
        string [] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for (int i=1; i< lines.Length; i++)
        {
            string [] parts = lines[i].Split(",");
            switch (parts[0])
            {
                case "SimpleGoal":
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
                break;

                case "CheckListGoal":
                CheckListGoal checkList = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]),int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checkList);
                break;

                case "EternalGoal":
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eternalGoal);
                break;


            }
        }
        
    }

    public void Start()
    {
        
    }
}