using System;
class Pyramid{

    public double length;
    public double breadth;
    public double height;

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
        double volume = breadth*length*height*0.5;
        return volume;
    }

    public double GetSurfaceArea()
    {
        double surfaceArea = length*breadth + length*height + breadth*height;
        return surfaceArea;
    }
}