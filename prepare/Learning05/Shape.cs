using System;

public abstract class Shape
{
    // Attributes
    private string _color;
    // Getters
    public string GetColor()
    {
        return _color;
    }
    // Setters
    public void SetColor(string color)
    {
        _color = color;
    }
    // Constructors
    public Shape()
    {

    }
    public Shape(string color)
    {
        _color = color;
    }
    // Methods
    public abstract double GetArea();
}