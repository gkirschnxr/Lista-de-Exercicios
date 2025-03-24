namespace Exercício09
{
    // A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
    // terreno e depois exibir a área do terreno.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            double resultado = comprimento * largura;

            Console.WriteLine($"A área do terreno é de {resultado} m²");
            Console.ReadLine();
        }
    }
}
