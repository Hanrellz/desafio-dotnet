using System.Collections.Generic;

namespace Prateleira.Prateleiras
{
    public class Suporte
    {
        private double DiametroFuro { get; set; }
        private int QuantidadeFuro { get; set; }
        public List<Furacao> Furacao { get; set; }

        public Suporte(double diametroFuros, int quantidadeFuros, List<Furacao> furacao)
        {
            this.DiametroFuro = diametroFuros;
            this.QuantidadeFuro = quantidadeFuros;
            this.Furacao = furacao;
        }
    }
}