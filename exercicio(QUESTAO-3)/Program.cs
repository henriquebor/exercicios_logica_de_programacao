using System;


namespace exercicio_QUESTAO_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            string[] convert = Console.ReadLine().Split(' ');
            string[] convert1 = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++)
            {
                A[i] = int.Parse(convert[i]);
            }
            
            for (int i=0; i<n; i++)
            {
                B[i] = int.Parse(convert1[i]);
            }
            int soma;
            
            for (int i=0; i<n; i++)
            {
                
                C[i] = A[i] + B[i];
                Console.WriteLine(C[i]);
            }
            Console.ReadLine();
            
        }
    }
}
