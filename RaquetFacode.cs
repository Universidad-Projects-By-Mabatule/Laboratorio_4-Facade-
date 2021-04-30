using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4_Facade_
{
    public class RaquetFacode
    {
        private IRacquetShop gearbox;
        private IRacquetShop prokennex;
        private IRacquetShop eforce;

        public RaquetFacode()
        {
            gearbox = new GearBox();
            prokennex = new Prokennex();
            eforce = new Eforce();
        }
        public void GearBoxSale()
        {
            gearbox.ModelNo();
            gearbox.Price();
            gearbox.Shape();
        }
        public void ProkennexgSale()
        {
            prokennex.ModelNo();
            prokennex.Price();
            prokennex.Shape();
        }
        public void EforceSale() 
        {
            eforce.ModelNo();
            eforce.Price();
            eforce.Shape();
        }
    }
}
