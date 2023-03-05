using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio30_ANIMAL_
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo, especie, alimentacao;

            tipo = Console.ReadLine();
            especie = Console.ReadLine();
            alimentacao = Console.ReadLine();

            if (tipo == "vertebrado")
            {
                if (especie == "ave")
                {
                    if (alimentacao == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (especie == "mamifero")
                {
                    if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (tipo == "invertebrado")
            {
                if (especie == "inseto")
                {
                    if (alimentacao == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (alimentacao == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (especie == "anelideo")
                {
                    if (alimentacao == "hemtafogo")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (alimentacao == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
            Console.ReadLine();
         }

     }
}

