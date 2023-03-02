using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio18_DISTANCENTREDOISPONTOS_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, resul;

            string[] vet1 = Console.ReadLine().Split(' ');

            string[] vet2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet1[0],CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            resul = Math.Sqrt( Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(resul.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
