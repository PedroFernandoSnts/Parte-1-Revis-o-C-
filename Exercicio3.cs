using System;

class Programa
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}