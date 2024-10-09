using System;
using System.Linq.Expressions;
namespace kap2upp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Hur långt hoppade Elin i meter? ");
                string elin = Console.ReadLine();
                double elindouble = double.Parse(elin);
                Console.Write("Hur långt hoppade Alma i meter? ");
                string alma = Console.ReadLine();
                double almadouble = double.Parse(alma);
                double skillnad = elindouble - almadouble;

                Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma.");
            }
        }
    }
}