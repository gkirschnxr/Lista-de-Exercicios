using System.Numerics;

namespace Exercicio06
{
    //      Crie um programa para calcular a média harmônica das notas de um Aluno
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas ultimas 3 notas para descobrir a média harmonica entre elas: ");

            Console.WriteLine("Primeira nota: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Terceira nota: ");
            decimal nota3 = Convert.ToDecimal(Console.ReadLine());

            decimal notasTotais = 3;

            decimal calculo2 = 1 / nota1 + 1 / nota2 + 1 / nota3;

            decimal calculo1 = notasTotais / calculo2;
            
            decimal calculo3 = Math.Abs(nota1 * nota2);

            int mdc(int a, int b) 
            { 
                if (a == 0) return b; return mdc(b % a, a); 
            
            
            
            }



            Console.WriteLine($"media {calculo3}");
            Console.ReadLine();
        }
    }
}
