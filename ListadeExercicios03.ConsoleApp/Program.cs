using System;

namespace ListadeExercicios03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] altura = new double[15];          

            Console.WriteLine("A seguir informa 15 valores para que o sistema ordene de forma crescente");
            double maior = 0;
            double menor = double.MaxValue;
            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write($"\nInforma o {i+1}º altura: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());
                if (altura[i] > maior) 
                { 
                    maior = altura[i]; 
                }
                if (altura[i] < menor) 
                { 
                menor = altura[i];
                }
            }
            Console.WriteLine($"A maior altura do grupo é {maior}, e a menor é {menor}");
        }
    }
}
