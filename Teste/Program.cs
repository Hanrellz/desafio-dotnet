using System;

namespace Teste
{
    class Program
    {     
            static void Main(string[] args)
            {
                Decimal Indice;
                string valor;
                int i = 1;

                while (i <= 7)
                {
                    Console.WriteLine("Agente por favor , Forneça o número para que possamos quebrar o cofre. ");
                    valor = Console.ReadLine();
                    Indice = long.Parse(valor);
                    Console.WriteLine("\nFibonacci \n");

                    Indice = CalculaValor(Indice);
                    Console.Write(AcrescentaZero(Indice) + " \n ");
                    i++;
                }
            }

            public static string AcrescentaZero(Decimal Numero)
            {
                string calculo = Numero.ToString();
                calculo = calculo.PadLeft(16, '0');
                return calculo;
            }

            public static Decimal CalculaValor(Decimal sequencia)
            {
                long fibonnaci = 0;
                long numPre = 0;
                long numPos = 1;

                for (int i = 1; i < sequencia; i++)
                {
                    fibonnaci = numPre + numPos;
                    numPre = numPos;
                    numPos = fibonnaci;

                    if (sequencia == i)
                    {
                        return fibonnaci;
                    }
                }
                return fibonnaci;
            }
        }
    }
}
