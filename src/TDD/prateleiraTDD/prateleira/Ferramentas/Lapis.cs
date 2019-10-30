namespace Prateleira.Ferramentas
{
    public class Lapis : Ferramenta
    {
        private bool LapisOk { get; set; }

        public Lapis(bool lapisOk)
        {
            this.LapisOk = lapisOk;
        }
        public override bool EstaFuncionando()
        {
            return LapisOk;
        }
    }
}
