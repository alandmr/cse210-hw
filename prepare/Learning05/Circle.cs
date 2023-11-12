using System;

class Circle : Shape
{
    private double _radius;

    public Circle(double r, string color) : base(color)
    {
        this._radius = r;

    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius,2);
    }
}