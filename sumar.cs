using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class sumar
    {
        double resultadoSuma;
        public sumar()
        {
        }

        public double suma(double n1, double n2)
        {
            resultadoSuma = n1 + n2;
            return resultadoSuma;
        }
    }
}