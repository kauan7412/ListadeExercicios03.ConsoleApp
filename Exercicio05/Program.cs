using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                              Exercício 5:
            //• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.       
            //Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
            Console.WriteLine("digite o numero que deseja saber a sua faturação:");
            double numero = Convert.ToDouble(Console.ReadLine());
            double resultado = numero;
            for (double i = numero - 1; i > 0; i--) 
            {
                resultado = resultado * i;
                Console.WriteLine($"\n{resultado}");
            }
        }
    }
}
