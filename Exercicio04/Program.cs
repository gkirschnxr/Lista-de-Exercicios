namespace Exercicio04
{
    // Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
    internal class Program
    {
        static void Main(string[] args)
        {
            // °F = °C × 1,8 + 32

            Console.Write("Digite qual a temperatura que deseja converter em Fahrenheit: ");
            decimal C = Convert.ToDecimal(Console.ReadLine());


            decimal resultado = C * 1.8m + 32;

            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"A temperatura {C}°C representa {resultado} graus na escala Fahrenheit");
            Console.ReadLine();
        }
    }
}
