using System;
using System.Collections.Generic;
using System.IO;

namespace Whiskey_Anzeigen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Marke> marken_liste = new List<Marke>();


            string[] infos = File.ReadAllLines("C:/Users/mdbas/OneDrive/Desktop/git Repository/Anzeigen_Whiskey/WhiskeyPreise.txt");

            string[] whiskey_infos= new string[infos.Length];



            for (int i = 0; i < infos.Length; i++)
            {
                whiskey_infos = infos[i].Split(':');
                Marke marke = new Marke(whiskey_infos[0], whiskey_infos[3]);
                marken_Liste.Add(marke);
            }

            for (int y = 0; y < infos.Length; y++)
            {

                whiskey_infos= infos[y].Split(':');
                whiskey_Typen.Marken = marken_liste;
                whiskey_Typen.Name = whiskey_infos[0];

            }


        }
    }
}
