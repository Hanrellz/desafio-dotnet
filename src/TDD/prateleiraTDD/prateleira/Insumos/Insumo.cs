using System;

namespace Prateleira.Insumos
{
    public abstract class Insumo
    {
        public const string MensagemQuantidadeSuperior = "Quantidade desejada superior a quantidade disponível";
        public const string MensagemDiametroSuperior = "Diametro disponível superior ao diametro desejado.";
        public const string MensagemDiametroInferior = "Diametro disponível inferior ao diametro desejado.";

        public double Diametro { get; set; }
        public int Quantidade { get; set; }

        public Insumo(double diametro, int quantidade)
        {
            this.Diametro = diametro;
            this.Quantidade = quantidade;
        }

        public abstract bool VerificarCompatibilidade(double diametroDesejado, int quantidadeDesejada);
        public bool VerificarQuantidade(int quantidadeDesejada)
        {
            if (Quantidade >= quantidadeDesejada)
                return true;
            else
                throw new Exception(MensagemQuantidadeSuperior);
        }

        public bool VerificarDiametro(double diametroDesejado)
        {
            if (Diametro == diametroDesejado)
                return true;
            else
            {
                if (Diametro > diametroDesejado)
                    throw new Exception(MensagemDiametroSuperior);
                else
                    throw new Exception(MensagemDiametroInferior);
            }
        }
    }
}
