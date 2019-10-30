using System;

namespace Prateleira.Ferramentas
{
    public class Furadeira : Ferramenta
    {
        public const string MensagemFuradeiraNaoLigada = "Furadeira não está ligada.";
        public const string MensagemFuradeiraRotacaoIncorreta = "Furadeira não está com a rotação em pleno funcionamento.";

        private bool Ligada { get; set; }
        private bool RotacaoOk { get; set; }

        public Furadeira(bool ligada, bool rotacaoOk)
        {
            this.Ligada = ligada;
            this.RotacaoOk = rotacaoOk;
        }
        public override bool EstaFuncionando()
        {
            if (Ligada && RotacaoOk)
                return true;
            else
            {
                if (!Ligada)
                    throw new Exception(MensagemFuradeiraNaoLigada);

                if (!RotacaoOk)
                    throw new Exception(MensagemFuradeiraRotacaoIncorreta);
            }

            return false;
        }
    }
}
