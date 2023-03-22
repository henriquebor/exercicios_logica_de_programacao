using System;
using System.Globalization;

namespace excercicio_VETOR_QUESTAO_4_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] convert = Console.ReadLine().Split(' ');

            double[] Media = new double[n];

            for (int i=0; i<n; i++)
            {
                Media[i] = double.Parse(convert[i],CultureInfo.InvariantCulture);
            }

            double soma= 0.0;
            for (int i=0; i<n; i++)
            {
                soma = soma + Media[i];// sempre em operações copm vetores é necessario declarar valores para variavel.
            }
            double media = soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i=0; i<n; i++)
            {
                if (Media[i] < media)
                {
                    Console.WriteLine(Media[i].ToString("F1",CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
