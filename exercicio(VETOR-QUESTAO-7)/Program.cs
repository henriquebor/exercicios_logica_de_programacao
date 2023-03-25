using System;
using System.Globalization;

namespace exercicio_VETOR_QUESTAO_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            // recebendo valores no vetor s e passando para os demais vetores.
            for (int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2],CultureInfo.InvariantCulture);
            }

            // Calculando média.
            double media = 0.0;
            Console.WriteLine("Alunos aprovados:");
            for (int i=0; i<n; i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6)
                {
                    Console.WriteLine(nomes[i]);
                }
                
            }

        }
    }
}
