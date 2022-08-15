using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        string? Num = Console.ReadLine();
        int NumLength = Num!.Length;
        bool Palindrom = true;
        for (int index = 0; index < (NumLength - 1)/2; index++)
        {
            if (Num[index] == Num[NumLength - 1 - index])
            {
                Palindrom = true;
            }
            else
            {
                Palindrom = false;
                break;
            }
        }

        if (Palindrom == true)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}