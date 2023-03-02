using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio20_IDADEEMDIAS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ano, mes, dia, resto;

            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            resto = N % 365;// modulo pega o resto da porcentagem.

            mes = resto / 30;
            dia = resto % 30;




            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
            Console.ReadLine();

        }
    }
}
