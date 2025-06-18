using System;

public class Rectangle : Shape
{
    // Attributes
    private double _length = 0f;
    private double _width = 0f;
    // Getters
    public double GetLength()
    {
        return _length;
    }
    public double GetWidth()
    {
        return _width;
    }
    // Setters
    public void SetLength(double length)
    {
        _length = length;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    // Contructors
    public Rectangle() : base()
    {

    }
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}