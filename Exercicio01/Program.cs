using System.Reflection.Metadata.Ecma335;

namespace Exercicio01
{
    // Crie um programa para calcular o volume de uma caixa retangular
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura da caixa em cm: ");
            // Largura
            double L = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da caixa em cm: ");
            // Altura
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a comprimento da caixa em cm: ");
            // Comprimento
            double C = Convert.ToDouble(Console.ReadLine());

            double V = L * h * C;

            Console.WriteLine($"O volume da caixa é {V} cm³");
            Convert.ToDouble(Console.ReadLine());
        }
    }
}
