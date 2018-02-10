using System;

public class Pyramid{

    double length;
    double breadth;
    double height;

    public Pyramid()
    {
        length = 0;
        breadth = 0;
        height = 0;
    }

    public void SetLength(double input)
    {
        length = input;
    }

    public void SetBreadth(double input)
    {
        breadth = input;
    }

    public void SetHeight(double input)
    {
        height = input;
    }

    public double GetVolume()
    {
        double volume = breadth*length*height/3;
        return volume;
    }

    public double GetSurfaceArea()
    {
        double surfaceArea = length*breadth + length*Math.Sqrt((breadth/2)*(breadth/2)+height*height)+breadth*Math.Sqrt((length/2*length/2+height*height));
        return surfaceArea;
    }
}