namespace Exercício13
{
    // Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 15;
            int B = 13;
            int C = 40;

            if (A + B < C)
                Console.WriteLine("A soma de A + B é menor que C");

            else
                Console.WriteLine("A soma de A + B é maior que C");


                Console.ReadLine();
        }
    }
}
