using System;
using System.Text.RegularExpressions;

namespace desafio_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("chave do cofre\r");
            Console.WriteLine("--------------\n");

            string valorInformado = "";


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Informe o código de até 16 dígitos");
               
                valorInformado = Console.ReadLine();

                if (validaEntrada(valorInformado))
                {
                    calculaChave(Int64.Parse(valorInformado));
                }
               
            }
        }

        static bool validaEntrada(string entrada)
        {

            bool bValido = false;

            if (entrada.Length > 16)
            {
                Console.WriteLine("Código de entrada inválido só é permitido valores inteiros de 16 posições\r");
               
                return false;
            }

            Regex regex = new Regex("^[0-9]+$");

            bValido = regex.IsMatch(entrada);

            if (!bValido)
            {
                Console.WriteLine("Código de entrada inválido só é permitido valores inteiros de 16 posições\r");
                Console.ReadKey();
                return false;

            }

            return true;

        }

         static void calculaChave(Int64 indice)
        {

            Int64 anterior = 0;
            Int64 atual = 1;
            Int64 proximo = 0;

            for (Int64 i = 2; i <= indice; i++)
            {

                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine("Resultado: = " + proximo.ToString().PadLeft(16,'0') + " Digite uma tecla para continuar.");
            Console.ReadLine();

        }
    }
}

