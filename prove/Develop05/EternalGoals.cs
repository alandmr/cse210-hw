using System;

class EternalGoal : Goals

{

    public EternalGoal(string gName, string gDescription, int gPoints, int gType) : base(gName, gDescription, gPoints, gType)
    {

    }

    public EternalGoal(){
        
    }
    public override void GoalCompleted(ref int globalPoint)
    {
        globalPoint += GetGoalPoints();
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");      
    }

    public override void GoalNotComplete(ref int globalPoint)
    {
        Console.WriteLine($"Sorry you lost {GetGoalPoints()} points!");
        globalPoint -= GetGoalPoints(); 
    }
}