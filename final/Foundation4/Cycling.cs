using System;

class Cycling : Activity{
    private double _speed;

    public Cycling(double speed, string date, int leng, int actType) : base(date, leng, actType){
        this._speed = speed;
    }

    public override double GetPace()
    {
        return 60/this._speed;
    }

    public override double GetDistance()
    {
        return _lengthActivity/GetPace();
    } 

    public double GetSpeedCycling(){
        return this._speed;
    }

    public override void GetSumary(string date, int lenActivity, double distancex, double speedx, double pacex){
        Console.WriteLine($"***** Summary of activity: Cycling *****");
        Console.WriteLine("");
        Console.WriteLine($"{date} Running ({lenActivity} min): Distance {GetDistance()} km, Speed: {this._speed} kph, Pace: {pacex} min per km");
        Console.WriteLine("");
        Console.WriteLine("");
    }  
}