namespace Prateleira.Ferramentas
{
    public class Nivel : Ferramenta
    {
        private bool NivelOk { get; set; }

        public Nivel(bool nivelOk)
        {
            this.NivelOk = nivelOk;
        }
        public override bool EstaFuncionando()
        {
            return NivelOk;
        }
    }
}
