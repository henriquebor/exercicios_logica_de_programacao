using System;


namespace exercicio_QUESTAO_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] pares = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++)
            {
                pares[i] = int.Parse(s[i]);
                
            }
            int resul;
            for (int i=0; i<n; i++)
            {
                resul = pares[i] % 2;
                
                if (resul == 0)
                {
                    Console.WriteLine(pares[i]);
                }
            }
            int resul2;
            int cont=1;
            for (int i=1; i<n; i++)
            {
                resul2 = pares[i] % 2;
                if(resul2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont); //fora ele pega a soma do cont e dentro
                                     //ele pega a sequência de numeros dos cont.
            

            


        }
    }
}
