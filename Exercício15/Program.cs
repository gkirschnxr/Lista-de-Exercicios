﻿using System.Runtime.Intrinsics.X86;

namespace Exercício15
{
//    O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//      a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
//      peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
//          ● IMC em adultos Condição
//          ● Abaixo de 18,5
//          ● Abaixo do peso
//          ● Entre 18,5 e 25 Peso normal
//          ● Entre 25 e 30
//          ● Acima do peso
//          ● Acima de 30 obeso
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu peso? ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual sua altura? ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
                Console.WriteLine($"Seu IMC é {IMC}, voce está abaixo do peso.");

            else if (IMC == 18.5 || IMC < 25)
                Console.WriteLine($"Seu IMC é {IMC}, voce está no seu peso ideal.");

            else if (IMC == 25 || IMC <= 30)
                Console.WriteLine($"Seu IMC é {IMC}, voce está acima do peso.");

            else if (IMC > 30)
                Console.WriteLine($"Seu IMC é {IMC}, voce está obeso.");


            Console.ReadLine();
        }
    }
}
