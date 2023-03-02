using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, PROD;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            PROD = X * Y;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();

        }
    }
}
