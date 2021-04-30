using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Facade_
{
    class Eforce:IRacquetShop
    {
        public void ModelNo() {
            Console.WriteLine("Raquetball: E-force");
        }
        public void Price() { 
           Console.WriteLine("Price: 220$");

        }
        public void Shape()
        {
            Console.WriteLine("Shape:(Q) square");
        }

    }
}
