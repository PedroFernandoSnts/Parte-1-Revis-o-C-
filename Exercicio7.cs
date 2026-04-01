using System;

class Programa
{
    static void Main()
    {
        int baseNum, expoente;
        int resultado = 1;

        Console.Write("Digite a base: ");
        baseNum = int.Parse(Console.ReadLine());

        Console.Write("Digite o expoente: ");
        expoente = int.Parse(Console.ReadLine());

        for (int i = 1; i <= expoente; i++)
        {
            resultado = resultado * baseNum;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}