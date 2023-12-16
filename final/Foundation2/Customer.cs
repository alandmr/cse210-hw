using System;

class Customer{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address){
        this._customerName = name;
        this._customerAddress = address;
    }

    public string GetCustomerName(){
        return this._customerName;
    }

    public Address GetCustomerAddress(){
        return this._customerAddress;
    }

}