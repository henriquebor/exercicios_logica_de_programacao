using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio22_MUTIPLOS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0 )
            {
                Console.WriteLine("Sao Mutiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Mutiplos");
            }
            Console.ReadLine();
        }
    }
}
