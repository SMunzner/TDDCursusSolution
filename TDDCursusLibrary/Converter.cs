using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public static class Converter
    {
        public static decimal InchesNaarCentimeters(decimal inches)
        {
            if(inches > 0)
            {
                return inches * 2.54m;
            }
            else { return 0; }
        }
    }
}
