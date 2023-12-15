using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TDDCursusLibrary
{
    public class Isbn
    {
        private static readonly Regex regex = new Regex("^(978|979)\\d{10}$");
        private readonly long isbn;

        public Isbn(long nummer)
        {
            if (!regex.IsMatch(nummer.ToString()))
                throw new ArgumentException("Verkeerd formaat");

            //zet long om in array van getallen
            string result = nummer.ToString().Substring(0, 12);
            var strings = result.Select(x => x.ToString()).ToArray();
            int[] array = Array.ConvertAll(strings, x => int.Parse(x));

            //som oneven getallen
            int somOneven = 0;
            for(int x = 0; x < array.Length; x+=2) 
            {
                somOneven += array[x];
            }

            //som even getallen * 3
            int somEven = 0;
            for(int i = 2; i < array.Length; i +=2)
            {
                somEven += array[i];
            }
            somEven *= 3;

            //naastgelegen tiental - som beiden
            int tiental = 0;
            while (tiental < somEven)
            {
                tiental += 10;
            }
            int laatsteCijfer = tiental - (somEven + somOneven);

            if(nummer.ToString().EndsWith($"{laatsteCijfer}"))
            {
                this.isbn = nummer;
            }
            else { throw new ArgumentException("Laatste nummer klopt niet"); }
            
        }

        public long GetIsbn()
        {
            return isbn;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
