using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FibonnaciTest
{
    public class SequenciaFibonacci
    {
        private List<int> indices { get; set; }
        private List<BigInteger> sequencia { get; set; }

        public SequenciaFibonacci(List<int> Indices)
        {
            if (Indices.Count > 0)
            {
                this.indices = Indices;

                Console.WriteLine($"Calculando valores fibonacci para os índices [{string.Join(",", indices.ToArray())}] ");
            }
            else
                throw new Exception("Lista de indíces vazia, verifique!");
        }

        public void GerarSequencia()
        {
            sequencia = new List<BigInteger>();

            for (int i = 0; i <= indices.Max(); i++)
            {
                if (i == 0 || i == 1)
                    sequencia.Add(i);
                else
                    sequencia.Add(sequencia[i - 1] + sequencia[i - 2]);
            }

            ImprimirLista();
        }

        private void ImprimirLista()
        {
            List<CodigosValidos> retorno = new List<CodigosValidos>();

            foreach (int indice in indices)
            {
                if (indice < sequencia.Count)
                {
                    if (sequencia[indice].ToString().Length == 16)
                        retorno.Add(new CodigosValidos(indice, sequencia[indice]));
                }
            }

            if (retorno.Count > 0)
            {
                foreach (var linha in retorno)
                    Console.WriteLine(linha.ToString());
            }
            else
                Console.WriteLine("Nenhum valor Fibonacci gerado atendeu o tamanho de 16 dígitos.");
        }
    }
}
