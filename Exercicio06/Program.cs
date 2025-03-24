using System.Numerics;

namespace Exercicio06;

//      Crie um programa para calcular a média harmônica das notas de um Aluno
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite suas ultimas 3 notas para descobrir a média harmonica entre elas: ");

        Console.Write("Primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double resultado = 3.0 / ((1.0 / nota1) + (1.0 / nota2) + (1.0 / nota3));


        Console.WriteLine("A média harmonica do aluno é: " + Math.Round(resultado));

        Console.WriteLine();
        Console.ReadLine();
    }
}
