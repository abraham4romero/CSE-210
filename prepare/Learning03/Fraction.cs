using System;

class Fraction
{
    private float nom;
    private float denom;

    public Fraction() {
        nom = 1;
        denom = 1;
    }

    public Fraction(int nomin) {
        nom = nomin;
        denom = 1;
    }

    public Fraction(int nomin, int denomin) {
        nom = nomin;
        denom = denomin;
    }

    public string GetFractionString() {
        return $"{nom}/{denom}";
    }

    public double GetDecimalValue() {
        double dec = (nom / denom);
        return dec;
    }
}