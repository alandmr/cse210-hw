using System;

class Lectures : Event {
    private string _speakerName;
    private int _limitedCapacity;

    public Lectures(string speaker, int capacity, string title, string description, string date, string time, Address address)
    : base(title, description, date, time, address){

        this._speakerName = speaker;
        this._limitedCapacity = capacity;
    }

    public void LecturesFullDetail(){
        Console.WriteLine("***** Event Type: Lectures - Full Details *****");
        Console.WriteLine("");

        StandardDetails();

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine($"Speaker: {this._speakerName}");
        Console.WriteLine($"Capacity: {this._limitedCapacity}");
    }
}