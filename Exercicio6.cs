using System;

class Programa
{
    static void Main()
    {
        int quantidade;
        double nota;
        double soma = 0;
        double media;

        Console.Write("Quantas notas deseja digitar? ");
        quantidade = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write("Digite a nota: ");
            nota = double.Parse(Console.ReadLine());
            soma = soma + nota;
        }

        media = soma / quantidade;

        Console.WriteLine("Média: " + media);
    }
}