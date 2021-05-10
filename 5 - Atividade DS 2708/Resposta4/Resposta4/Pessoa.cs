using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resposta4
{
    class Pessoa
    {
        public double IMC(double x, double k)
        {
            double i;
            i = x / (k * k);
            return i;
        }
    }
}
