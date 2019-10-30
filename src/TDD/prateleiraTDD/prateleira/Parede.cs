using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prateleira.Prateleiras;

namespace Prateleira
{
    public class Parede
    {
        public const string MensagemFuracaoIncompativel = "Furação desejada incompatível com as dimensões da parede.";
        public const string MensagemParedeNaoSuportaPrateleira = "Parede não suporta a prateleira, medidas incompatíveis.";

        private double Altura { get; set; }
        private double Largura { get; set; }
        private PrateleiraObj Prateleira { get; set; }

        public Parede(double altura, double largura, PrateleiraObj prateleira)
        {
            this.Altura = altura;
            this.Largura = largura;
            this.Prateleira = prateleira;
        }
        public bool FuracaoOk()
        {
            foreach (Furacao item in Prateleira.Suporte.Furacao)
            {
                if ((item.PosicaoX < 0 || item.PosicaoY < 0) || (item.PosicaoX > Largura || item.PosicaoY > Altura))
                    throw new Exception(MensagemFuracaoIncompativel);
            }
            return true;
        }

        public bool SuportaPrateleira()
        {
            if ((this.Altura >= Prateleira.Altura && this.Largura >= Prateleira.Largura))
                return true;
            else
                throw new Exception(MensagemParedeNaoSuportaPrateleira);
        }
    }
}
