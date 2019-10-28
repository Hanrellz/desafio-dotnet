using System;
using System.Diagnostics;

namespace Teste_Codigos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sw = new Stopwatch();

                /*As pistas (índices) das senhas. Vale lembrar que será executado a cada vez o 
                 * cálculo para encontrar o valor correspondente de cada índice. 
                 * Para encontrar estes índices eu utilizei o mesmo cálculo de forma reversa, inclusive.*/
                int[] pistas = new int[7];
                pistas[0] = 74;
                pistas[1] = 75;
                pistas[2] = 76;
                pistas[3] = 75; //Repetição do 75, pois só existem 5 valores com 16 digitos 
                pistas[4] = 74; //Repetição di 74, pois só existem 5 valores com 16 digitos 
                pistas[5] = 77;
                pistas[6] = 78;

                for (int i = 0; i < pistas.Length; i++)
                {
                    sw.Reset();

                    Console.WriteLine(String.Format("Pista {0}: {1}", (i + 1), pistas[i]));

                    /*Considerei informar a senha em tela (encontrá-la a cada iteração) em vez de 
                     * fazer o usuário digitar - visto o grande tamanho de cada senha - 
                     * para facilitar o teste e validação*/
                    Console.WriteLine("Pressione ENTER para encontrar em até 3 segundos o código...");
                    Console.ReadKey();

                    sw.Start();
                    Console.WriteLine(
                        String.Format(
                            "Código {0}: {1}",
                            (i + 1),
                            retornaFib(
                                Convert.ToInt64(pistas[i])
                                )
                            )
                        );
                    sw.Stop();

                    Console.WriteLine(String.Format("Tempo decorrido (em milisegundos) para localizar o código: {0}", sw.Elapsed.TotalMilliseconds));
                }

                Console.WriteLine("Ótimo! Finalizado com sucesso!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static long retornaFib(long indice)
        {
            if (indice <= 92 && indice >= 0)
            {
                var quadrado5 = Math.Sqrt(5);
                var maxFib = (quadrado5 + 1) / 2;
                var minFib = maxFib - 1;
                return Convert.ToInt64((Math.Pow(maxFib, indice) - Math.Pow(-minFib, indice)) / quadrado5);
            }
            else
                throw new Exception("Índice inválido!");
        }
    }
}
