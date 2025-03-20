namespace Exercicio02
{
    // Crie um programa para calcular o volume de um Cilindro
    internal class Program
    {
        static void Main(string[] args)
        {
            // V = πr²h
            Console.Write("Digite o valor do raio em metros: ");
            // raio
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura em metros: ");
            // altura
            double h = Convert.ToDouble(Console.ReadLine());

            double V = Math.PI * Math.Pow(r, 2) * h;

            Console.WriteLine($"O volume do cilindro é: {V} m³");
            Console.ReadLine();
        }
    }
}
