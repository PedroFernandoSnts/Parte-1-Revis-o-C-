using System;

class Programa
{
    static void Main()
    {
        int numero;
        int divisores = 0;

        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            Console.WriteLine("É primo");
        }
        else
        {
            Console.WriteLine("Não é primo");
        }
    }
}