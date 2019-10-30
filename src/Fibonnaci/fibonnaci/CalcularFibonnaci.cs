using System.Collections.Generic;

namespace FibonnaciTest
{
    class CalcularFibonacci
    {
        static void Main(string[] args)
        {
            SequenciaFibonacci sequencia = new SequenciaFibonacci(new List<int> { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79 });
            sequencia.GerarSequencia();
        }
    }
}
