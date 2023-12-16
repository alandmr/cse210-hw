using System;

abstract class Goals
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _goalState;
    protected int _goalType;

    public Goals(string gName, string gDescription, int gPoint, int gType){
        this._goalName = gName;
        this._goalDescription = gDescription;
        this._goalPoints = gPoint;
        this._goalType = gType;
    }

    public Goals(){
        Console.Write("What is the name of your goal? ");
        this._goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        this._goalDescription =  Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        this._goalPoints = int.Parse(Console.ReadLine());
    }

    public void SetGoalType(int type){
        this._goalType = type;
    }

    public void SetGoalPoint(int gpoint){
        this._goalPoints = gpoint;
    }

    public void SetGoalName(string gname){
        this._goalName = gname;
    }

    public void SetGoalDescription(string gDescription){
        this._goalDescription = gDescription;
    }

     public string GetGoalName()
    {
        return this._goalName;
    }


    public string GetGoalDescription()
    {
        return this._goalDescription;
    }


    public int GetGoalPoints()
    {
        return this._goalPoints;
    }

    public void SetState(bool state)
    {
        this._goalState = state;
                
    }

    public bool GetState()
    {
        return this._goalState;
    }

    public int GetGoalType()
    {
        return this._goalType;
    }

    public abstract void GoalCompleted(ref int globalPoint);


    public abstract void GoalNotComplete(ref int globalPoint);

}