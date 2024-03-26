using System;

class Square : Rectangle
{
    public Square(float side, string color) : base(color) {
        sideX = side;
        sideY = side;
    }
}