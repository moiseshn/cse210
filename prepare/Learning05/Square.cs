using System;

public class Square : Shape
{
    // Attributes
    private double _side = 0f;
    // Getters
    public double GetSide()
    {
        return _side;
    }
    // Setters
    public void SetSide(double side)
    {
        _side = side;
    }
    // Contructors
    public Square() : base()
    {

    }
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}