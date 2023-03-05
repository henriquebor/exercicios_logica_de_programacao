using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio29_TEMPODEJOGO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal;

            string[] tempo = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(tempo[0]);
            minutoInicial = int.Parse(tempo[1]);
            horaFinal = int.Parse(tempo[2]);
            minutoFinal = int.Parse(tempo[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else

            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaohoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaohoras + " HORAS(S) E " + duracaoMinutos + " MINUTO(S)");

            Console.ReadLine();
        }
    }
}
