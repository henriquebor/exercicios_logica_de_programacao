using System;
using System.Globalization;


namespace exercicio44_VETOR_NUMEROS_REAIS_
{
    class Program
    {
        static void Main(string[] args)
        {
         
            

           int n = int.Parse(Console.ReadLine());

            double[] reais = new double[n];
            string[] valores = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++)
            {
                reais[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
            }
            double maior = reais[0];
            int posicaoMaior = 0;
            for (int i=1; i<n; i++)
            {
                if (reais[i] > maior)
                {
                    maior = reais[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
            Console.ReadLine();
        }
    }
}
