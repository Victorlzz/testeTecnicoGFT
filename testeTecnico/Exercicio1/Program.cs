using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número com 4 dígitos");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1000 || numero > 9999)
            {
                Console.WriteLine("Número inválido");
            }

            string numeroString = Convert.ToString(numero);
            int numeroTamanho = numeroString.Length;
            int tentativas = 0;

            if (numeroTamanho == 4)
            {
                Console.WriteLine("Número Válido");
                /*char [] n = numeroString.ToCharArray(0, 4);
                Console.WriteLine(n);*/

            }else
            {
                while (numeroTamanho < 4 || numeroTamanho > 4)
                {
                    Console.WriteLine("O número precisa conter 4 dígitos");
                    numero = Convert.ToInt32(Console.ReadLine());
                    numeroString = Convert.ToString(numero);
                    numeroTamanho = numeroString.Length;
                    tentativas++;



                }

            }

           
        }
    }
}
