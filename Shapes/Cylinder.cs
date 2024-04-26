using System;

public class Cylinder
{
    public static void Main(string[] args){
        Console.WriteLine("Radius");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Height of cylinder");
        double h = Convert.ToDouble(Console.ReadLine());
        double p = Math.PI;
        double sf = ((2*p*(Math.Pow(r,2)))+((2*p*r)*h));
        Console.WriteLine(sf);
    }

}