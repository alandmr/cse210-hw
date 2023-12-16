using System;

class Product{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string pName, string pId, double pPrice, int pQuantity){
        this._productName = pName;
        this._productId = pId;
        this._productPrice = pPrice;
        this._productQuantity = pQuantity;
    }

    public string GetProductName(){
        return this._productName;
    }

    public string GetProductId(){
        return this._productId;
    }

    public double GetProductPrice(){
        return this._productPrice;
    }

    public int GetProductQuantity(){
        return this._productQuantity;
    }

    public double TotalCost(double price, int quantity){
        return price * quantity;

    }
    
}