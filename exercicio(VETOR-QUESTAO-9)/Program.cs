using System;
using System.Globalization;

namespace exercicio_VETOR_QUESTAO_9_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] alimentos = new string [n];
            double[] precoDeCompra = new double[n];
            double[] precoDeVenda = new double[n];

            for (int i=0; i<n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                alimentos[i] = vet[0];
                precoDeCompra[i] = double.Parse(vet[1],CultureInfo.InvariantCulture);
                precoDeVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            double lucro = 0.0;
            double porcent = 0.0;
            int cont = 0;


            for (int i=0; i<n; i++)
            {
                lucro = precoDeCompra[i] - precoDeVenda[i];
                porcent = (lucro / precoDeCompra[i]) * 100;
                cont++;

                if (porcent < 10)
                {
                    cont++;
                }
            }
            Console.WriteLine("lucro abaixo de 10%:" + cont);
            
        }
    }
}
