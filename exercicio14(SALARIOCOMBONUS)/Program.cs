using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio14_SALARIOCOMBONUS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendas, salarioFinal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            salarioFinal = (totalVendas * 0.15) + salario;


            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
