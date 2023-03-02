using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_AREACIRCULO_
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi = 3.14159,Area;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Math.Pow(R, 2.0) * pi;

            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
            
            Console.ReadLine();


        }
    }
}
