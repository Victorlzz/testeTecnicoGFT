using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedagem hospedagem = new Hospedagem();
            hospedagem.Valor = 62.55;
            hospedagem.PrintValor();

            HospedagemVIP hospedagemVip = new HospedagemVIP(hospedagem.Valor);
            hospedagemVip.PrintHospedagemVip();
        }
    }
}
