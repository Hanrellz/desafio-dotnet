using System;
using System.Diagnostics;

namespace TesteLinux
{
    class Program
    {
        private static bool temPistaRepetida = false;
        private static int[] pistas = new int[7];

        static void Main(string[] args)
        {
            try
            {
                Principal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("MISSÃO ABORTADA!!!");
                Console.Write("Pressione qualquer tecla para fechar a app");
                Console.Read();
            }
        }

        private static void Principal()
        {
            string valConsole;
            int val, count;
            bool indiceValido;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Forneça a pista " + (i + 1) + ": ");
                valConsole = Console.ReadLine();

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                if (!int.TryParse(valConsole, out val))
                {
                    throw new Exception("Pista inválida!");
                }

                count = 0;

                foreach (int item in pistas)
                {
                    if (val == item)
                    {
                        count++;
                    }
                }

                if (count == 3 || (count == 1 && temPistaRepetida))
                {
                    temPistaRepetida = true;
                    Console.Write("Foi execedido a quantidade de pista repetida! Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    i--;
                    continue;
                }

                pistas[i] = val;

                indiceValido = false;

                long[] resultado = Fibonacci(val);

                for (int j = 0; j < resultado.Length; j++)
                {
                    if (resultado[j].ToString().Length == 16)
                    {
                        int indice = j + 1;

                        if (indice == val)
                        {
                            indiceValido = true;
                            stopwatch.Stop();
                            Console.WriteLine("Tempo decorrido para encontrar o código: " + stopwatch.Elapsed);
                            Console.WriteLine("Código secreto " + (i + 1) + ": " + resultado[j]);

                            if (i == 6)
                            {
                                Console.WriteLine("MISSÃO CUMPRIDA!!!");
                                Console.Write("Pressione qualquer tecla para fechar a app");
                                Console.Read();
                            }
                        }
                    }
                }

                if (!indiceValido)
                {
                    throw new Exception("Pista inválida!");
                }
            }
        }

        private static long[] Fibonacci(int limite)
        {
            long numAnterior = 1;
            long numPosterior = 1;
            long[] resultado = new long[limite];

            for (int i = 0; i < limite; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                        resultado[i] = 1;
                        break;
                    default:
                        long soma = numAnterior + numPosterior;
                        numPosterior = numAnterior;
                        numAnterior = soma;
                        resultado[i] = soma;
                        break;
                }
            }

            return resultado;
        }
    }
}
