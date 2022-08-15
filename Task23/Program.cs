using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        int Num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= Num; i++)
        {
            if (i != Num)
            {
                Console.Write(Math.Pow(i, 3) + ", ");
            }
            else
            {
                Console.Write(Math.Pow(i, 3));
            }
        }
    }
}