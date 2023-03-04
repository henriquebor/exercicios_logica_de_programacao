using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio25_INTERVALO_
{
    class Program
    {
        static void Main(string[] args)
        {
            double
              valorQualquer;
              

            valorQualquer = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (valorQualquer < 0.0 || valorQualquer > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            } 
            else if (valorQualquer <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(valorQualquer <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(valorQualquer <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            Console.ReadLine();
        }
    }
}
