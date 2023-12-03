using System;

class CheckListGoals : Goals
{
    private int _timesAccomplished;
    private int _goaltimesAccomplished;
    private int _bonusPoint;

    public CheckListGoals(string gName, string gDescription, int gPoints, int gType, int tAccomplished, int bonus) : base(gName, gDescription, gPoints, gType)
    {
        this._timesAccomplished = tAccomplished;
        this._goaltimesAccomplished = 0;
        this._bonusPoint = bonus;
    }

    public CheckListGoals(){
       this._goaltimesAccomplished = 0; 
    }

    public void SetTimesAccomplished(int timesAcc){
        this._timesAccomplished = timesAcc;
    }

    public void SetBonusPoints(int bonus){
        this._bonusPoint = bonus;
    }

    public int GetTimesAccomplished()
    {
        return this._timesAccomplished;
    }

    public int GetBonusPoint()
    {
        return this._bonusPoint;
    }

    public int GetGoaltimesAccomplished()
    {
        return this._goaltimesAccomplished;
    }

    public void SetGoaltimesAccomplished(int _goaltimesAccomplished)
    {
        this._goaltimesAccomplished = _goaltimesAccomplished;
    }

    public override void GoalCompleted(ref int globalPoint)
    {        

        globalPoint += GetGoalPoints();
        _goaltimesAccomplished++;
        
        if (_goaltimesAccomplished < _timesAccomplished)
        {
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        }
        
        if (_goaltimesAccomplished == _timesAccomplished)
        {
            globalPoint += _bonusPoint;
            SetState(true);
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()+_bonusPoint} points!");
        }
    }

    public override void GoalNotComplete(ref int globalPoint)
    {
        globalPoint -= GetGoalPoints();
        _goaltimesAccomplished--;
        
        if (!GetState())
        {
            Console.WriteLine($"Sorry you lost {GetGoalPoints()} points!");
        }
        else
        {
            globalPoint -= _bonusPoint;
            SetState(false);  
            Console.WriteLine($"Sorry you lost {GetGoalPoints()-_bonusPoint} points!");
        }
    }




}