using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Facade_
{
    public class GearBox : IRacquetShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Raquetball: GearBox");
        }
        public void Price()
        {
            Console.WriteLine("Price: 245$");

        }
        public void Shape()
        {
            Console.WriteLine("Shape:(T) Drop");
        }
    }
}
