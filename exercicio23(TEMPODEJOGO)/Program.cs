using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio23_TEMPODEJOGO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, T;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial < horaFinal)
            {
                T = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + T + " HORA(S)");
            }
            else
            {
                T = (24 - horaInicial) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + T + " HORA(S)");
            }
            Console.ReadLine();
        }
    }
}
