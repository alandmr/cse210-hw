using System;

class Swimming : Activity{
    private int _laps;

    public Swimming(int laps, string date, int leng, int actType) : base(date, leng,actType){
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return this._laps*50/1000;
    }

    public override double GetSpeed()
    {
        return GetDistance()/_lengthActivity *60;
    }

    public override double GetPace()
    {
        return _lengthActivity/GetDistance();
    }

    public override void GetSumary(string date, int lenActivity, double distancex, double speedx, double pacex){
        Console.WriteLine($"***** Summary of activity: Swimming *****");
        Console.WriteLine("");
        Console.WriteLine($"{date} Running ({lenActivity} min): Distance {GetDistance()} km, Speed: {Math.Round(GetSpeed(),2)} kph, Pace: {GetPace()} min per km");
        Console.WriteLine("");
        Console.WriteLine("");
    }  
}