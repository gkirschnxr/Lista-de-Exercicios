namespace Exercício19
{
    // Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
    // encontram no conjunto dos números de 1 até 500.

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }

                Console.ReadLine();
        }
    }
}
