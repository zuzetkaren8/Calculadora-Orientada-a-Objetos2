using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class multiplicar
    {
        double resultadoMultiplica;
        public multiplicar()
        {
        }

        public double multiplica(double n1, double n2)
        {
            resultadoMultiplica = n1 * n2;
            return resultadoMultiplica;
        }
    }
}
