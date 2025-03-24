using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio08
{
    // Crie um programa para verificar se um número é primo.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numeroDigitado = Convert.ToDouble(Console.ReadLine());


            if (isPrimo (numeroDigitado))
                Console.WriteLine($"O número {numeroDigitado} é primo!");

            else
                Console.WriteLine($"O número {numeroDigitado} NÃO é primo");


                Console.ReadLine();
        }

        static bool isPrimo(double numeroDigitado)
        {
            if (numeroDigitado <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numeroDigitado); i++)
            {
                if (numeroDigitado % i == 0)
                    return false;
            }

            return true;
        }
    }
}
