using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio09_ESFERA_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, media;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = x / y;

            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
