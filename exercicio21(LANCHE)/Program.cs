using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio21_LANCHE_
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantItem;
            double preco1 = 4.00, preco2 = 4.50, preco3 = 5.00, preco4 = 2.00, preco5 = 1.50, valor;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantItem = int.Parse(vet[1]);

            if(codigo == 1)
            {
                valor = quantItem * preco1;
                Console.WriteLine("Total: R$ " + valor.ToString("F2",CultureInfo.InvariantCulture));
            } else if(codigo == 2)
            {
                valor = quantItem * preco2;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }else if (codigo == 3) 
            {
                valor = quantItem * preco3;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 4)
            {
                valor = quantItem * preco4;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }else if (codigo == 5)
            {
                valor = quantItem * preco5;
                Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
