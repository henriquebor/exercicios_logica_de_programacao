using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio42_MAIOREPOSICAO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int pos = 1;

            for (int i=1; i<=100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = x;
                    pos = 1;
                }
                else if (x > maior)
                {
                    maior = x;
                    pos = i;
                }
                
            }
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
