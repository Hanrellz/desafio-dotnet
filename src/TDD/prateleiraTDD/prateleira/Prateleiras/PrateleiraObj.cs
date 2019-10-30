using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Prateleiras
{
    public class PrateleiraObj
    {
        public double Largura { get; set; }
        // altura da prateleira, não em relação ao SOLO
        public double Altura { get; set; }
        public Suporte Suporte { get; set; }

        public PrateleiraObj(double altura, double largura, Suporte suporte)
        {
            this.Altura = altura;
            this.Largura = largura;
            this.Suporte = suporte;
        }
    }
}
