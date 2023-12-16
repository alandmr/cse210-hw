using System;

class OutdoordGatherings : Event{
    private string _weatherForecast;

    public OutdoordGatherings(string wForecast, string title, string description, string date, string time, Address address)
    : base(title, description, date, time, address){

        this._weatherForecast = wForecast;
    }

    public void WForecastFullDetail(){
        Console.WriteLine("***** Event Type: Outdoor gatherings - Full Details *****");
        Console.WriteLine("");

        StandardDetails();

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine($"Statement of the weather: {this._weatherForecast}");        
    }
}