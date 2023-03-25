using System;
using System.Globalization;

namespace exercico_VETOR_QUESTAO_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            char[] sexo = new char[n];

            for (int i=0; i<n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);
            }

            //Menor altura.

            double menorAltura = altura[0];
            for(int i=0; i<n; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                   
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            
            //Maior altura.

            double maiorAltura = altura[0];
            for (int i=0; i<n; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i]; 
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            //Soma das alturas das mulheres

            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            double media = 0.0;
            
            for (int i=0; i<n; i++)
            {
                if (sexo[i] == 'f')
                {
                    somaDasAlturasDasMulheres += altura[i];
                    contMulheres++;
                }
                if(contMulheres == 0)
                {
                    Console.WriteLine("Não ha nenhum mulher dentre as pessoas");
                }
                else
                {
                    media = somaDasAlturasDasMulheres / contMulheres;
                    
                }
            }
            Console.WriteLine("Media da altura das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            
            //Quantidade de homens.

            int contHomens = 0;
            for (int i=0; i<n; i++)
            {
                if (sexo[i] == 'm')
                {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
