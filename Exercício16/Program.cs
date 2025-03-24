namespace Exercício16
{
    // Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número digitado é par.");

            else
                Console.WriteLine("O número digitado é ímpar.");

            Console.ReadLine();
        }
    }
}
