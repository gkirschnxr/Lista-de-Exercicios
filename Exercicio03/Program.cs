namespace Exercicio03
{
//          Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.O
//          programa deve solicitar ao usuário:
//              ● A quilometragem inicial do veículo no início da viagem.
//              ● A quilometragem final ao término da viagem.
//              ● A quantidade de combustível consumida durante a viagem(em litros).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor inicial da quilometragem inicial do veículo: ");
            double KmInicial = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite o valor final da quilometragem inicial do veículo: ");
            double KmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumida durante a viagem (em litros) ");
            double QuantidadeConsumida = Convert.ToDouble(Console.ReadLine());

            double resultado = (KmFinal - KmInicial) / QuantidadeConsumida;

            Console.WriteLine("______________________________________________");
            Console.WriteLine($"O consumo do carro por quilômetro foi de {resultado} litros por km");
            Console.ReadLine();
        }
    }
}
