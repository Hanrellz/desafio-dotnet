namespace Prateleira.Ferramentas
{
    public class Regua : Ferramenta
    {
        private double Tamanho { get; set; }

        public Regua(double tamanho)
        {
            this.Tamanho = tamanho;
        }

        public override bool EstaFuncionando()
        {
            return Tamanho > 0;
        }
    }
}
