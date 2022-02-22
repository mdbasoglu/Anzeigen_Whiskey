using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiskey_Anzeigen
{
    internal class Marke
    {

        private string _name;
        private string _preis;

        public string Name { get=>_name; set=>Name=value; }
        public string Preis { get=>_preis; set=>_preis=value; }



        public Marke (string _name, string _preis)
        {
            Name = _name;
            Preis = _preis; 
        }


      


    }
}
