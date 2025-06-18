using System;

public class Circle : Shape
{
    // Attributes
    private double _radius = 0f;
    // Getters
    public double GetRadius()
    {
        return _radius;
    }
    // Setters
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    // Contructors
    public Circle() : base()
    {

    }
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}