using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rechthoek
    {
        public int Lengte { get; set; }
        public int Breedte { get; set; }

        public Rechthoek(int lengte, int breedte)
        {
            Lengte = lengte;
            Breedte = breedte;
        }

        public int Oppervlakte()
        {
            if(Lengte > 0 && Breedte > 0) 
            {
                return Lengte * Breedte;
            }
            else { return 0; }
        }

        public int Omtrek()
        {
            if (Lengte > 0 && Breedte > 0)
            {
                return (Lengte + Breedte) * 2;
            }
            else { return 0; }
        }


    }
}
