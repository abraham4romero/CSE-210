using System;

public abstract class Shape
{
    protected string _shapeColor;
    public Shape(string color) {
        _shapeColor = color;
    }

    public Shape() {
        _shapeColor = "Not set";
    }

    public void SetColor(string c) {
        _shapeColor = c;
    }

    public string GetColor() {
        return _shapeColor;
    }

    public abstract float GetArea();
}