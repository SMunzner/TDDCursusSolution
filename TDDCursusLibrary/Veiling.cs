using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBod = 0;

        public void DoeBod(decimal bedrag)
        {
            //throw new NotImplementedException();
            if(bedrag > hoogsteBod && bedrag > 0) 
                hoogsteBod = bedrag;
        }

        public decimal HoogsteBod 
        {  
            get 
            {
                /*throw new NotImplementedException();*/
                return hoogsteBod;
            } 
        }
    }
}
