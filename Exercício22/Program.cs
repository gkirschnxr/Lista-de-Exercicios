using System.ComponentModel;
using System.ComponentModel.Design;

namespace Exercício22;

// Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para visualizar a sequência de Fibonacci até esse número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c = 1;

        while (b <= numero)
        {
            c = a + b;

            a = b;
            b = c;


            if (c <= numero)
                Console.Write($"{b}, ");

            else
                Console.Write($"{b}. ");
        } 





        // 1+1 2, 1+2 3, 2+3 5, 3+5 8...
        // a+b c

        Console.ReadLine();
    }
}
