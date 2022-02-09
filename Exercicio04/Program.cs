using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("digite o numero que deseja saber a sua tabuada:");
            double N = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
          for (int i = 0; i <= 10; i++)
          {
             resultado = N * i;
                Console.WriteLine($"\n{resultado}");
          }
        }
    }
}
