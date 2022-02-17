using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiskey_Anzeigen
{
    internal class Typ
    {

        private string _name;
        private List<Marke> marken_liste;

        public string Name { get=>_name; set=>_name=value; }

        public Typ() { }

        public string Marken_Typ(string _name)
        {
            Name = _name;
        }



    }
}
