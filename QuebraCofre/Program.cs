using QuebraCofre.Services;
using QuebraCofre.Util;
using System;

namespace QuebraCofre
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxCountCodigo = 0;
            int MaxCodigo = 7;

            var quebrarCofreService = new QuebrarCofreService();

            while (MaxCountCodigo < MaxCodigo)
            {
                try
                {
                    Console.WriteLine("Digite o Código:");
                    var codigo = long.Parse(Reader.ReadLine(3000));

                    if (!quebrarCofreService.IsDigitoValido(codigo))
                    {
                        Console.WriteLine("Código é menor que 16 digitos números");
                        ExitProgram();
                    }

                    if (!quebrarCofreService.ContainsCodigo(codigo))
                    {
                        Console.WriteLine("Sequencia errada");
                        ExitProgram();
                    }

                    var result = quebrarCofreService.Quebrar(codigo);

                    Console.WriteLine($"Pista: {result}");

                    MaxCountCodigo++;
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Desculpe, você demorou demais.");
                    Console.ReadKey();
                }
            }
        }

        private static void ExitProgram()
        {
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
