using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio17_OMAIOR_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, Resul, Resul2;

            string[] vet = Console.ReadLine().Split();
            
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            Resul = (a + b + Math.Abs(a - b)) / 2;
            Resul2 = (Resul + c + Math.Abs(Resul - c)) / 2;



            Console.WriteLine(Resul2 + " eh o maior");
            Console.ReadLine();
        }
    }
}
