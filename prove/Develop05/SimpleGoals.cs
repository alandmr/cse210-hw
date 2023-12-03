using System;

class SimpleGoals : Goals{

    public SimpleGoals(){

    }

    public SimpleGoals(string gName, string gDescription, int gPoints, int gType) : base(gName, gDescription, gPoints, gType)
    {

    }

    public override void GoalCompleted(ref int globalPoint)
    {

        _goalState = true;
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        globalPoint += _goalPoints;
        
    }

    public override void GoalNotComplete(ref int globalPoint)
    {
        Console.WriteLine($"Sorry you lost {_goalPoints} points!");
        globalPoint -= _goalPoints; 
        _goalState = false;
    }

}