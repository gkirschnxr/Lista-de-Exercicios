﻿namespace Exercício23;

//          Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
//          múltiplos de 3 pela palavra "Fizz" e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de
//          ambos, use "FizzBuzz".
internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");

            else if (i % 5 == 0)
                Console.WriteLine("Buzz");

            else if (i % 3 == 0)
                Console.WriteLine("Fizz");

            else
                Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
