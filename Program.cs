using System;

namespace TesteDotNet
{
    class Program
    {
        const int qtdCodigos = 7;
        static void Main(string[] args)
        {
            long seq = 0;
            for (int i = 0; i < qtdCodigos; i++)
            {
                Console.WriteLine($"Informe o índice do código {i+1} para obter o seu valor: ");
                seq = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"O valor do código {i+1} é {Fibonacci(seq).ToString("D16")}");
            }
        }

        static long Fibonacci(long indFib) 
        {
            long x = 0, y = 1, z = 0;

            for (int i = 0; i < (indFib-1); i++)
            {
                z = x + y;
                x = y;
                y = z;
            }

            return z;
        }
    }
}
