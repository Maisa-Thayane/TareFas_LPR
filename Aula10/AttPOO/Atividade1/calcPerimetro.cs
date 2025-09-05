using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class calcPerimetro
    {
        public double Perimetro;
        public calcPerimetro(double Altura, double Largura)
        {
            Perimetro = 2 * (Largura + Altura);
        }
    }
}
