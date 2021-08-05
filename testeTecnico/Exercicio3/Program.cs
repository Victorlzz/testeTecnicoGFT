using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia do seu aniversario");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês do seu aniversario");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano do seu aniversario");
            int ano = Convert.ToInt32(Console.ReadLine());

            //Ia mudar pra switch: case mas não deu tempo
            if (dia < 1 || dia > 31)
            {
                Console.WriteLine("Você digitou um dia inválido, digite um dia entre 1 e 31");

            }
            else if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Você digitou um mês inválido, digite um mes entre 1 e 12");

            }
            else if (ano < 1920 || ano > 2020)
            {
                Console.WriteLine("Você digitou um anos inválido, digite um ano entre 1920 e 2020");

            }
            //dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12 && ano >= 1920 && ano <= 2020
            else
            {
                Console.WriteLine("Data Válida");

            }
        }
    }
}
