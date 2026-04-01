using System;

class Programa
{
    static void Main()
    {
        int numero;
        int fatorial = 1;

        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 1; i--)
        {
            fatorial = fatorial * i;
        }

        Console.WriteLine("Fatorial: " + fatorial);
    }
}