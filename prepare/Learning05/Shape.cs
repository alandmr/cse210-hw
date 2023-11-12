using System;

abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        this._color = color;
    }

    public string GetColor()
    {
        return this._color;
    }

    public void SetColor(string _color)
    {
        this._color = _color;
    }

    public abstract double GetArea();
    
        
    


}