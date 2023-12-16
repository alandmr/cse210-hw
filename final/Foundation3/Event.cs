using System;

class Event{
    protected string _title;
    protected string _description;
    protected string  _date;
    protected string _time;
    protected Address _addressEvent; 

    public Event(string title, string description, string date, string time, Address address){       
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._addressEvent = address;
    }

    public void StandardDetails(){
        Console.WriteLine($"Title: {this._title}");
        Console.WriteLine($"Description: {this._description}");
        Console.WriteLine($"Date: {this._date}");
        Console.WriteLine($"Time: {this._time}");
        Console.WriteLine($"Address: {this._addressEvent.GetAddress()}");
    }

    public string GetTitle(){
        return this._title;
    }

    public string GetDate(){
        return this._date;
    }

    public void MessageShortDescription(string eventx, string title, string datex){

        Console.WriteLine($"***** Type Event: {eventx} - Short description *****");
        Console.WriteLine($"");
        Console.WriteLine($"Event Title: {title}");
        Console.WriteLine($"Event Date: {datex}");

    }    

}