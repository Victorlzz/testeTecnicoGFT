﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Hospedagem
    {
        public double Valor { get; set; }

        public Hospedagem()
        {
            
        }

        public void PrintValor()
        {
            Console.WriteLine("O valor da sua hospedagem é {0}", Valor);
        }
    }



    
}
