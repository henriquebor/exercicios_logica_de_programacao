using System;
using System.Globalization;
namespace exercicio_VETOR_QUESTAO_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] convert = Console.ReadLine().Split(' ');

            int[] Pares = new int[n];

            for (int i=0; i<n; i++)
            {
                Pares[i] = int.Parse(convert[i]);
            }
            int cont = 0;
            int resto;
            int resul;
            int soma = 0;
            for (int i=0; i<n; i++)
            {
                resto = Pares[i] % 2;
                if (resto == 0)
                {
                    soma = soma + Pares[i];
                    cont++;
                }
            }
            resul = soma / cont;

            Console.WriteLine(resul.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
