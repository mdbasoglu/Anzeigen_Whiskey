using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiskey_Anzeigen
{
    internal class Typ :Marke
    {

        private string _name;
        private List<Marke> marken_liste;

        public string Name { get=>_name; set=>_name=value; }

        public Typ(string _name)
        
        { 
            Name=_name;
        }



        public override string ToString()
        {
            return $"{Marke[0].Name},{Name}, {Marke[0].Preis}";
        }
    }
}
