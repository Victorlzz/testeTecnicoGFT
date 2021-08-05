using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class HospedagemVIP : Hospedagem
    {
        public double TaxaVip { get; set; }

        public HospedagemVIP(double valor)
        {
            Valor = valor;
            this.TaxaVip = (Valor) + 50;
        }

        public void PrintHospedagemVip()
        {
            Console.WriteLine("O valor da hospedagem VIP é {0}", TaxaVip);
        }
    }
}


