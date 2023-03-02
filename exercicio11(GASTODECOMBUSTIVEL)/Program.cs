using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio11_GASTODECOMBUSTIVEL_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double consumoMedio,tempo, velocidade;


            tempo = double.Parse(Console.ReadLine());
            velocidade = double.Parse(Console.ReadLine());

            consumoMedio = tempo * velocidade / 12;

            Console.WriteLine(consumoMedio.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadLine();
            

        }
    }
}
