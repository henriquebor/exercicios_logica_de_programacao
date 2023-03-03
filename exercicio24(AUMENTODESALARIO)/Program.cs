using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio24_AUMENTODESALARIO_
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario,novoSalario,reajuste;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                novoSalario = (salario * 0.15) + salario;
                
                reajuste = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            } 
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                novoSalario = (salario * 0.10) + salario;

                reajuste = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                novoSalario = (salario * 0.07) + salario;

                reajuste = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                novoSalario = (salario * 0.04) + salario;

                reajuste = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
            Console.ReadLine();
            
        }
    }
}
