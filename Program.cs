using System;
using System.IO;

namespace ShapTesting
{
    class Program
    {
        static void Main()
        {
            string lineBreak = "----------------------------";
            string readLine;
            Box box = new Box();
            Pyramid pyramid = new Pyramid();
            Sphere sphere = new Sphere();
            Console.WriteLine("Welcome to shape maker! Let's find" +
                " and volume and surface area for a few shapes...");
            Console.WriteLine(lineBreak);
            Console.WriteLine("Lets start with a box. Please enter the length of a box: ");
            readLine = Console.ReadLine();
            box.SetLength(Convert.ToDouble(readLine));
            Console.WriteLine("Please enter the height of a box: ");
            readLine = Console.ReadLine();
            box.SetHeight(Convert.ToDouble(readLine));
            Console.WriteLine("Please enter the breadth of a box: ");
            readLine = Console.ReadLine();
            box.SetBreadth(Convert.ToDouble(readLine));
            Console.WriteLine("The volume for your box: " + box.GetVolume());
            Console.WriteLine("The surface area for your box: " + box.GetSurfaceArea());
            Console.WriteLine(lineBreak);
            Console.WriteLine("Next let's try a pyramid. Please enter the length of a pyramid: ");
            readLine = Console.ReadLine();
            pyramid.SetLength(Convert.ToDouble(readLine));
            Console.WriteLine("Please enter the height of a pyramid: ");
            readLine = Console.ReadLine();
            pyramid.SetHeight(Convert.ToDouble(readLine));
            Console.WriteLine("Please enter the breadth of a pyramid: ");
            readLine = Console.ReadLine();
            pyramid.SetBreadth(Convert.ToDouble(readLine));
            Console.WriteLine("The volume for your pyramid: " + pyramid.GetVolume());
            Console.WriteLine("The surface area for your pyramid: " + pyramid.GetSurfaceArea());
            Console.WriteLine(lineBreak);
            Console.WriteLine("Now let's try a Sphere! Please enter the radius of a sphere: ");
            readLine = Console.ReadLine();
            sphere.SetRadius(Convert.ToDouble(readLine));
            Console.WriteLine("The volume for your sphere: " + sphere.GetVolume());
            Console.WriteLine("The surface area for your sphere: " + sphere.GetSurfaceArea());
            Console.WriteLine(lineBreak);
        }
    }
}
