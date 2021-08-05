using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Investimento
    {
        public double ValorInicial { get; set; }
        public double JurosMensais { get; set; }
        public Investimento(double valorInicial, double jurosMensais)
        {
            ValorInicial = valorInicial;
            JurosMensais = jurosMensais/100;
        }

        public virtual double CalcularLucro(int meses)
        {
            return (Math.Pow(ValorInicial * (1 + JurosMensais), meses));
        }
    }
}
