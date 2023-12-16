using System;

class Activity{
    protected string _date;
    protected int _lengthActivity;
    protected int _actType;

    public Activity(string date, int leng, int actType){
        this._date = date;
        this._lengthActivity = leng;
        this._actType = actType;
    }

    public virtual double GetDistance(){
        return 0;
    }
    public virtual double GetSpeed(){
        return 0;
    }
    public virtual double GetPace(){
        return 0;
    }

    public virtual void GetSumary(string date, int lenActivity, double distancex, double speedx, double pacex){
        Console.WriteLine($"***** Summary of activity: (Edit Activity) *****");
        Console.WriteLine("");
        Console.WriteLine($"{date} (Edit Activity) ({lenActivity} min): Distance {distancex} km, Speed: {speedx} kph, Pace: {pacex} min per km");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    public string GetDate(){
        return this._date;
    }

    public int GetLenghtActivity(){
        return this._lengthActivity;
    }

    public int GetActivityType(){
        return this._actType;
    }
    
}