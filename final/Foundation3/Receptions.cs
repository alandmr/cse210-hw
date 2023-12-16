using System;

class Receptions : Event{
    private string _rsvp;

    public Receptions(string rsvp, string title, string description, string date, string time, Address address)
    : base(title, description, date, time, address){

        this._rsvp = rsvp;
    }

    public void ReceptionsFullDetail(){
        Console.WriteLine("***** Event Type: Receptions - Full Details *****");
        Console.WriteLine("");

        StandardDetails();

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine($"Email: {this._rsvp}");        
    }
}