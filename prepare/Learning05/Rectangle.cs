using System;

class Rectangle : Shape
{
    protected float sideX;
    protected float sideY;

    public Rectangle(float x, float y, string colo) {
        sideX = x;
        sideY = y;
        _shapeColor = colo;
    }

    public Rectangle(string colo) {
        _shapeColor = colo;
    }

    public override float GetArea() {
        return (sideX * sideY);
    }
}