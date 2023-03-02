using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio15_CALCULARVOLUME_
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi=3.14159, volume;

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            volume = (4 / 3.0) * pi * Math.Pow(R,3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
