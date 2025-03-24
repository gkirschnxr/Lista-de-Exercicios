using System.Runtime.ConstrainedExecution;

namespace Exercício10
{
    //  A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
    // pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
    // venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10% do total arrecadado).
    // Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
    // quantidades de pães e de broas, e depois calcular os dados solicitados.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de pães vendida: ");
            double pao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de broas vendida: ");
            double broa = Convert.ToDouble(Console.ReadLine());

            double resultadoPao = pao * 0.12;
            double resultadoBroa = broa * 1.5;

            double resultadoVendas = resultadoPao + resultadoBroa;

            double resultadoDeposito = resultadoVendas * 0.1;

            Console.WriteLine("\nO valor vendido foi de: R$" + resultadoVendas.ToString("F2") + " reais. \n\nO valor que deve ser depositado é de: R$" + resultadoDeposito.ToString("F2") + " reais");
            Console.ReadLine();
        }
    }
}
