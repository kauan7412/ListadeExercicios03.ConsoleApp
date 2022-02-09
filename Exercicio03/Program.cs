using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double resto = 0;
            for (int i = 1; i < 500; i++)
            {               
                if (i % 3 == 0)
                {
                    numero += i; 
                    Console.WriteLine($"\n{numero}");

                }
            }
        }
    }
}