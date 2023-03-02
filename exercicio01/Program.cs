using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercico01
{
    class Program
    {
        static void Main(string[] args)
        {
            double R,R2,R3, A, A2, A3;
            
            double P = 3.14159;
            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            R2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = P * (R * R);
            A2 = P * (R2 * R2);
            A3 = P * (R3 * R3);

            Console.WriteLine("A= " + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A= " + A2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A= " + A3.ToString("F4", CultureInfo.InvariantCulture));

            
        }
    }
}
