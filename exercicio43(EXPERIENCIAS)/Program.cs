using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio43_EXPERIENCIAS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int sapos = 0;
            int ratos = 0;

            for (int i =0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int quantia = int.Parse(vet[0]);
                char tipo = char.Parse(vet[1]);

                if (tipo == 'c') 
                {
                    coelhos += quantia;

                }
                else if (tipo == 'r')
                {
                    ratos += quantia;
                }
                else
                {
                    sapos += quantia;
                }
            }

            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;

            Console.WriteLine("total: " + total + " cobaias");
            Console.WriteLine("total de coelhos: " + coelhos);
            Console.WriteLine("total de coelhos: " + ratos);
            Console.WriteLine("total de coelhos: " + sapos);

            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + "%");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + "%");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + "%");

            Console.ReadLine();
        }
    }
}
