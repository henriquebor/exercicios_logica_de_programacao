﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_RESOLVIDOCALC_H_M_S__
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();


        }
    }
}
