using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio08_CALCULOSIMPLES_
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, numP1, numP2;
            double valorP1, valorP2, valorPago, valorTotal;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            cod1 = int.Parse(vet[0]);
            numP1 = int.Parse(vet[1],CultureInfo.InvariantCulture);
            valorP1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            cod2 = int.Parse(vet2[0]);
            numP2 = int.Parse(vet2[1], CultureInfo.InvariantCulture);
            valorP2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorTotal = (numP1 * valorP1) + (numP2 * valorP2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            




        }
    }
}
