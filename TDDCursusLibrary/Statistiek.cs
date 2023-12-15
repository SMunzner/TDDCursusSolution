using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Statistiek
    {
        public static decimal Gemiddelde(decimal[] getallen)
        {
            if (getallen == null)
                throw new ArgumentNullException("Mag niet null zijn");
            if (getallen.Length == 0)
                throw new ArgumentException("Het aantal getallen moet groter zijn dan 0");
            //var totaal = decimal.Zero;
            //foreach (var getal in getallen)
            //    totaal += getal;
            //return totaal / getallen.Length;

            //Refactoring
            return getallen.Average();
        }
    }
}
