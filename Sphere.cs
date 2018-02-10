using System;
public class Sphere{

    double radius;

    public Sphere()
    {
        radius = 0;
    }

    public void SetRadius(double input)
    {
        radius = input;
    }

    public double GetVolume()
    {
        double volume = (4 * Math.PI * radius * radius * radius)/3;
        return volume;
    }

    public double GetSurfaceArea()
    {
        double surfaceArea = 4 * Math.PI * radius * radius;
        return surfaceArea;
    }
}