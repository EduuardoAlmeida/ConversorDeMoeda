using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    public class CalculoDolar
    {
        public static double CalcularDolar(double cotacao, double quantidade)
        {
            double valorDolar = cotacao * quantidade;
            double iof = 0.06;

            return (valorDolar * iof) + valorDolar;
        }
    }
}
