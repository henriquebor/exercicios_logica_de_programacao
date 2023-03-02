using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, worked_hours;
            double hourly_wage, monthly_salary;

            number = int.Parse(Console.ReadLine()); //numero de entrada.
            worked_hours = int.Parse(Console.ReadLine());//horas trabalhadas.
            hourly_wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//salario hora.

            monthly_salary = worked_hours * hourly_wage;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + monthly_salary.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
