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

            // 1: encontrar a quantidade para cada faixa de lucro desejada.

            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;

            for (int i=0; i<n; i++)
            {
                double lucro = precoDeVenda[i] - precoDeCompra[i];

                double porcentagemDeLucro = lucro / precoDeCompra[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if(porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            // 2: achar os totais

            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i=0; i<n; i++)
            {
                totalCompra += precoDeCompra[i];
                totalVenda += precoDeVenda[i];
            }

            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
