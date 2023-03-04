using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio26_MEDIA3_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, mediaFinal, notaExame;

            string[] vet = Console.ReadLine().Split(' ');
            
            n1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1],CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2],CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3],CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;


            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }

            else if (media >= 5 && media <= 6.9)
            {
                
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                
                notaExame = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                
                mediaFinal = (notaExame + media) / 2;
                if (mediaFinal >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }else
                {
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();

        }
    }
}
