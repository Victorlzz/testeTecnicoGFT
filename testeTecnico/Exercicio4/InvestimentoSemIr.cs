using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class InvestimentoSemIr : Investimento
    {

        public override double CalcularLucro(int meses)
        {
            double desconto;
            switch (meses)
            {
               case 1: 
                    desconto = 22.5;
                    break;
                case 2:

 
            }
            

        }
    }
}
