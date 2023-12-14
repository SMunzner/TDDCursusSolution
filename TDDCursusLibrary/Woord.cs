using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Woord
    {
        private string wwoord;

        public Woord(string nWoord) 
        {
            Wwoord = nWoord;
        }

        public string Wwoord 
        {
            get { return wwoord; }
            set { wwoord = value;}
             
        }

        public bool IsPalindroom() 
        {
            if(Wwoord != null)
            {
                return Wwoord.SequenceEqual(wwoord.Reverse());
            }
            else { return false; }
        }
    }
}

