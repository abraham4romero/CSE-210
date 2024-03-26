using System;

class Circle : Shape
{
    private float _radius;

    public Circle(float rad, string colo) {
        _radius = rad;
        _shapeColor = colo;
    }

    public override float GetArea() {
        float area = (float)(Math.PI*Math.Pow(_radius, 2));
        return area;
    }
}