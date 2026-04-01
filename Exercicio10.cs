using System;

class Programa
{
    static void Main()
    {
        int a = 0;
        int b = 1;
        int c;

        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 3; i <= 15; i++)
        {
            c = a + b;
            Console.WriteLine(c);

            a = b;
            b = c;
        }
    }
}