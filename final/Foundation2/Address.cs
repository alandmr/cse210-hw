using System;

class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _insideUS;

    public Address(string street, string city, string state, string country, bool insideUS){
        this._streetAddress = street;
        this._city = city;
        this._state = state;
        this._country = country;
        this._insideUS = insideUS;
    }

    public string GetAddress(){
        string address = this._streetAddress+", "+this._city+", \n"+
        ""+this._state+", "+this._country;

        return address;
    }

    public bool GetInsideUS(){
        return this._insideUS;
    }

}