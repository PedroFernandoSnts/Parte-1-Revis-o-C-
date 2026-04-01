using System;

class Programa
{
    static void Main()
    {
        int x;

        Console.Write("Digite um número: ");
        x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}