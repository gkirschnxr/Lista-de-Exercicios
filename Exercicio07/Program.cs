namespace Exercicio07
{
    // Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua primeira nota: ");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite sua segunda nota: ");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine());

            decimal totalDeNotas = 2;

            decimal resultado = (primeiraNota + segundaNota) / totalDeNotas;


            Console.WriteLine("A média ponderada das suas notas é: " + resultado);
            Console.ReadLine();
        }
    }
}
