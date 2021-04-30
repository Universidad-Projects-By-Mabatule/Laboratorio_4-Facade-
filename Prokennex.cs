using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Facade_
{
    public class Prokennex : IRacquetShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Raquetball: Prokennex");
        }
        public void Price()
        {
            Console.WriteLine("Price: 210$");

        }
        public void Shape()
        {
            Console.WriteLine("Shape:(Q) square");
        }
    }
}
