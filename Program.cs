using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long mainFib = 1;
            long lastFib = 1;           
            long fibBackUp = 0;
            int indexCnt = 2;

            Dictionary<int, long> indexFib = new Dictionary<int, long>();           

            while (true)
            {
                indexCnt++;

                fibBackUp = mainFib;

                mainFib = lastFib + mainFib;                

                lastFib = fibBackUp;


                int length = mainFib.ToString().Length;

                if (length >= 17)
                {
                    break;
                }

                if (mainFib.ToString().Length == 16)
                {
                    indexFib.Add(indexCnt, mainFib);
                }
            }

            string cmdReturn = string.Empty;
            int index;            

            Console.Write("Digite o índice da série de Fibonacci ou ok para encerrar: ");
            cmdReturn = Console.ReadLine();

            while (cmdReturn != "ok")
            {
                try
                {
                    index = Convert.ToInt32(cmdReturn);
                    if (indexFib.ContainsKey(index))
                    {
                        Console.WriteLine("A resultante é: " + indexFib[index]);
                    }
                    else
                    {
                        Console.WriteLine("Este índice resulta numa série que não contém 16 dígitos.");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Você não digitou um número inteiro");
                    Console.WriteLine("Ocorreu o erro: " + ex.Message);                    
                }

                Console.WriteLine();
                Console.Write("Digite o índice da série de Fibonacci ou ok para encerrar: ");
                cmdReturn = Console.ReadLine();
            }
        }
    }
}
