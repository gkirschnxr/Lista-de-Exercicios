namespace Exercicio12
{
    // Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
    // impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO!");
            Console.Write("\nQual seu salário atual? ");
            decimal salarioAtual = Convert.ToDecimal(Console.ReadLine());

            decimal aumentoSalarial = salarioAtual * Convert.ToDecimal(0.15) + salarioAtual;
            Console.WriteLine("\nApós o aumento seu salário bruto ficará R$" + aumentoSalarial.ToString("F2"));

            decimal deducaoSalarial = aumentoSalarial * Convert.ToDecimal(0.08) - aumentoSalarial;
            Console.WriteLine("\nE o salário líquido ficará R$" + Math.Abs(deducaoSalarial));

           
            Console.ReadLine();
        }
    }
}
