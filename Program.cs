using System;
using System.Text;

namespace TesteFocalle
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong txtFibonacci;

            Console.WriteLine("\n");
            Console.WriteLine("------------------------\r");
            Console.WriteLine("Desafio quebrar o cofre:\r");
            Console.WriteLine("------------------------\r");

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Informe o {i + 1}º código: ");

                try
                {
                    txtFibonacci = Convert.ToUInt64(Console.ReadLine());
                    Console.WriteLine($"Série:{ CalculoFibonacci(txtFibonacci)}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Código de entrada inválido! Digite somente valores inteiros!\r");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Pressione uma telca para finalizar!\r");

            Console.ReadKey();


        }

        public static string CalculoFibonacci(ulong indice)
        {
            ulong anterior = 0;
            ulong atual = 1;

            for (ulong i = 0; i < indice; i++)
            {
                ulong proximo = anterior;
                anterior = atual;
                atual = proximo + atual;
            }
            return anterior.ToString().PadLeft(16, '0');
        }
    }
}