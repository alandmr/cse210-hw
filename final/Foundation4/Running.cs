using System;

class Running : Activity {
    private double _distance;

    public Running(double distance, string date, int leng, int actType) : base(date, leng, actType){
        this._distance = distance;
    }

    public override double GetSpeed()
    {
        return this._distance / _lengthActivity*60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }

    public double GetDistanceRunning(){
        return this._distance;
    }

    public override void GetSumary(string date, int lenActivity, double distancex, double speedx, double pacex){
        Console.WriteLine($"***** Summary of activity: Running *****");
        Console.WriteLine("");
        Console.WriteLine($"{date} Running ({lenActivity} min): Distance {this._distance} km, Speed: {speedx} kph, Pace: {pacex} min per km");
        Console.WriteLine("");
        Console.WriteLine("");
    }    
}