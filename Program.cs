using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie eine ganze positive Zahl ein: ");
        int number = int.Parse(Console.ReadLine());

        if (!CheckPrime(number))
        {
            Console.WriteLine($"{number} ist eine Primzahl.");
        }
        else
        {
            Console.WriteLine($"{number} ist keine Primzahl.");
        }
    }

    static bool CheckPrime(int number)
    {
        for (int i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
                return true;
        }
        return false;
    }
}
