using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resto = 0;
            for (int i = 100; i <= 200; i++) 
            {
                resto = i % 2;
                if (resto != 0)
                {
                    Console.WriteLine($"\n {i} é impar");
                }
            }
        }
    }
}
