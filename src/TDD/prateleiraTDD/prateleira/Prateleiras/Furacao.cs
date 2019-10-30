using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prateleira.Prateleiras
{
    public class Furacao
    {
        public double PosicaoX  { get; set; }
        public double PosicaoY { get; set; }

        public Furacao(double posicaoX, double posicaoY)
        {
            this.PosicaoX = posicaoX;
            this.PosicaoY = posicaoY;
        }
    }
}
