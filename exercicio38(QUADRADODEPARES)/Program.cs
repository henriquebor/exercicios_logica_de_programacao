﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio38_QUADRADODEPARES_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++)
            {
                if (i % 2 ==0)
                {
                    int resultado = i * i;
                    Console.WriteLine(i + "^2 = " + resultado);
                }
            }
            Console.ReadLine();
        }
    }
}
