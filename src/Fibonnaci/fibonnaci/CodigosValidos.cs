using System.Numerics;

namespace FibonnaciTest
{
    public class CodigosValidos
    {
        private int indice { get; set; }
        private BigInteger codigo { get; set; }

        public CodigosValidos(int indice, BigInteger codigo)
        {
            this.indice = indice;
            this.codigo = codigo;
        }

        public override string ToString()
        { 
            return $"Indice: {indice} - Código: {codigo}";
        }
    }
}
