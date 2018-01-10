using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class SeguroDeVida: ITributavel
    {
        const double imposto = 42.0;

        public double CalculaTributos()
        {
            return imposto;
        }
    }
}
