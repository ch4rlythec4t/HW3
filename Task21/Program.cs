using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите координаты (x,y,z) для точки A:");
        Console.Write("X(a) = ");
        double Xa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y(a) = ");
        double Ya = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z(a) = ");
        double Za = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты (x,y,z) для точки B:");
        Console.Write("X(b) = ");
        double Xb = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y(b) = ");
        double Yb = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z(b) = ");
        double Zb = Convert.ToDouble(Console.ReadLine());

        double Distance = Math.Round(Math.Sqrt(Math.Pow((Xa - Xb), 2) + Math.Pow((Ya - Yb), 2) + Math.Pow((Za - Zb), 2)), 2);

        Console.Write("Расстояние между точками A и B равняется " + Distance);
    }
}