using System;

// Shape interface
interface Shape
{
    void Draw();
}

// Concrete Circle class
class Circle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

// Concrete Square class
class Square : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

// Shape Factory
class ShapeFactory
{
    // Factory method to create shapes
    public Shape CreateShape(string shapeType)
    {
        if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
        {
            return new Circle();
        }
        else if (shapeType.Equals("Square", StringComparison.OrdinalIgnoreCase))
        {
            return new Square();
        }
        return null; // Return null for unknown shapes
    }
}

// Main class
class FactoryPatternExample
{
    static void Main()
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        // Create a Circle
        Shape circle = shapeFactory.CreateShape("Circle");
        if (circle != null)
        {
            circle.Draw();
        }

        // Create a Square
        Shape square = shapeFactory.CreateShape("Square");
        if (square != null)
        {
            square.Draw();
        }

        // Try creating an unknown shape
        Shape unknownShape = shapeFactory.CreateShape("Triangle");
        if (unknownShape != null)
        {
            unknownShape.Draw();
        }
        else
        {
            Console.WriteLine("Unknown shape. Cannot draw.");
        }
    }
}
