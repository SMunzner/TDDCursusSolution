using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldo;
        private List<decimal> stortingen = new List<decimal>();

        public void Storten(decimal bedrag)
        {
            if (bedrag <= decimal.Zero)
                throw new ArgumentException("Het bedrag moet positief zijn.");
            
            saldo += bedrag;
            stortingen.Add(bedrag);
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public List<decimal> Stortingen()
        {
            //throw new NotImplementedException();
            return stortingen;
        }
        public List<decimal> StortingenGesorteerd()
        {
            //throw new NotImplementedException();

            decimal[] arrayGesorteerd = stortingen.ToArray();
            Array.Sort<decimal>(arrayGesorteerd);
            var listGesorteerd = arrayGesorteerd.ToList();

            return listGesorteerd;
        }

    }
}
