using System;

class Programa
{
    static void Main()
    {
        int inicio, fim, soma = 0;

        Console.Write("Digite o número inicial: ");
        inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        fim = int.Parse(Console.ReadLine());

        for (int i = inicio; i <= fim; i++)
        {
            soma = soma + i;
        }

        Console.WriteLine("Soma: " + soma);
    }
}