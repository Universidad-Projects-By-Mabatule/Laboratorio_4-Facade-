using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Facade_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Raquets Shop *********");
            Console.WriteLine("Models:");
            Console.WriteLine("1. Gear Box");
            Console.WriteLine("2. E-force");
            Console.WriteLine("3. Prokennex ");
            //ejemplo
            RaquetFacode Store= new RaquetFacode();
            Store.GearBoxSale();
            Console.WriteLine("*******************************");
            Store.ProkennexgSale();
            Console.WriteLine("*******************************");
            Store.EforceSale();
        }
    }
}
