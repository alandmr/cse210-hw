using System;

class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double len, double wid, string color) : base(color)
    {
        this._length = len;
        this._width = wid;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}