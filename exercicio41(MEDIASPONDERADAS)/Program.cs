using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio41_MEDIASPONDERADAS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i< n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double n1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double medias = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
                Console.WriteLine(medias.ToString("F1",CultureInfo.InvariantCulture));

            }

        }
    }
}
