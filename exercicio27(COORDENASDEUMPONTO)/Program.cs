using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio27_COORDENASDEUMPONTO_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1;

            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1],CultureInfo.InvariantCulture);
            

            if(x1 == 0 && y1 == 0)
            {
                Console.WriteLine("Origem");
            }
            
            else if (x1 != 0 && y1 == 0)
            {
                Console.WriteLine("Eixo X");
            }
            
            else if (x1 == 0 && y1 != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            
            else if (x1 > 0 && y1 > 0)
            {
                Console.WriteLine("Q1");
            }
            
            else if (x1 < 0 && y1 > 0)
            {
                Console.WriteLine("Q2");
            }
            
            else if (x1 < 0 && y1 < 0)
            {
                Console.WriteLine("Q3");
            }
            
            else 
            {
                Console.WriteLine("Q4");
            }
            
            Console.ReadLine();
        }
    }
}
