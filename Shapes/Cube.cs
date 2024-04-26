using System;

public class Cube
{
    public static void Main(string[] args)
    {
        Console.WriteLine("length of one side?");
        double length = Convert.ToDouble(Console.ReadLine());
        double sf = 6*(Math.Pow(length,2));
        Console.WriteLine("The surface area of the cube is "+sf);
    }
}