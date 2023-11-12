using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapeList = new List<Shape>();

        Square square = new Square("Yellow",2);
        shapeList.Add(square);

        Rectangle rectangle = new Rectangle(3,2,"Blue");
        shapeList.Add(rectangle);

        Circle circle = new Circle(2,"Red");
        shapeList.Add(circle);

        foreach(Shape shapes in shapeList)
        {                                  
           Console.WriteLine($"The {shapes.GetColor()} shape has an area of {shapes.GetArea()}");
        }
        

    }
}