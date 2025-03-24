namespace Exercicio_14
{
    // Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 10;
            int valor2 = 25;
            int valor3 = 23;

            if (valor1 > valor2 && valor1 > valor3 && valor2 > valor3)
                Console.WriteLine($"{valor1}\n{valor2}\n{valor3}");

            else if (valor1 > valor2 && valor1 > valor3 && valor3 > valor2)
                Console.WriteLine($"{valor1}\n{valor3}\n{valor2}");

            else if (valor2 > valor1 && valor2 > valor3 && valor1 > valor3)
                Console.WriteLine($"{valor2}\n{valor1}\n{valor3}");

            else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
                Console.WriteLine($"{valor2}\n{valor3}\n{valor1}");

            else if (valor3 > valor1 && valor3 > valor2 && valor1 > valor2)
                Console.WriteLine($"{valor3}\n{valor1}\n{valor2}");

            else if (valor3 > valor1 && valor3 > valor2 && valor2 > valor1)
                Console.WriteLine($"{valor3}\n{valor2}\n{valor1}");


            Console.ReadLine();
        }
    }
}
