using System;


namespace exercicio_VETOR_QUESTAO_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i=0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);

            }
            int maiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int i=1; i<n; i++)
            {
                if(idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    posicaoMaiorIdade = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
            


        }
    }
}
