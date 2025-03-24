namespace Exercício17
{
//      Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//      contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//      variável C e mostrar seu conteúdo na tela.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (A): ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um número (B): ");
            double B = Convert.ToDouble(Console.ReadLine());

            double C;

            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"Os valores A e B são iguais, a soma dos valores é: {C}");

            }
            else
            {
                C = A * B;
                Console.WriteLine($"Os valores A e B são diferentes, a multiplicação dos valores é: {C}");
            }



            Console.ReadLine();
        }
    }
}
