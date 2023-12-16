using System;

class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;    

    public Address(string street, string city, string state, string country){
        this._streetAddress = street;
        this._city = city;
        this._state = state;
        this._country = country;        
    }

    public string GetAddress(){
        string address = this._streetAddress+", "+this._city+", \n"+
        ""+this._state+", "+this._country;

        return address;
    }
}