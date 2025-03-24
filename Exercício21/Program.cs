namespace Exercício21;

//      Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
//      resultado.
//      a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//      b.Pesquise sobre “fatorial”
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escreva o número que deseja saber seu fatorial (!): ");
        int A = Convert.ToInt32(Console.ReadLine());

        int fatorial = 1;

        for (int i = A; i > 0; i--)
        {
            fatorial *= i;

            if (i == 1)
                Console.Write($"{i} = ");

            else 
                Console.Write($"{i} x ");
        }
        Console.Write(fatorial);

        Console.ReadLine();
    }
}
