namespace Exercicio05
{
//          Crie um programa para calcular o salário total de um vendedor.
//          Deverá ser informado o salário base e o total de vendas.
//          A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do salário base do vendedor: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o valor total das vendas do vendedor em reais: ");
            decimal totalDeVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a porcentagem da comissão do vendedor: ");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());

            decimal calculoComissao = comissao / 100;

            decimal resultado = (totalDeVendas * calculoComissao) + salarioBase;

            // Console.WriteLine($"O salário total do vendedor será de: R$ {resultado:F2}");
            Console.WriteLine("O salário total do vendedor será de: " + resultado.ToString("F2")); 
            Console.ReadLine();
        }
    }
}
