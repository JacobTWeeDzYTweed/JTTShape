using System;
public class Box {

    double length;
    double breadth;
    double height;

    public Box() {
        length = 0;
        breadth = 0;
        height = 0;
    }

    public void SetLength (double input) {
        length = input;
    }

    public void SetBreadth(double input) {
        breadth = input;
    }

    public void SetHeight (double input) {
        height = input;
    }

    public double GetVolume () {
        double volume = length*breadth*height;
        return volume;
    }

    public double GetSurfaceArea() {
        double surfaceArea = height*breadth*2 + height*length*2 + length*breadth*2;
        return surfaceArea;
    }
}