using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Artikel
    {
        public decimal PrijsExclusiefBtw {  get; set; }
        public decimal BtwPercentage { get; set; }

        public Artikel(decimal prijsExclusiefBtw, decimal btwPercentage) 
        { 
            PrijsExclusiefBtw = prijsExclusiefBtw;
            BtwPercentage = btwPercentage;
        }

        public decimal PrijsInclusiefBtw()
        {
            if(BtwPercentage > 0 && BtwPercentage < 1 && 
                PrijsExclusiefBtw > 0)
            {
                return PrijsExclusiefBtw * (1 + BtwPercentage);
            }
            else { return 0m; }
        }
    }
}
