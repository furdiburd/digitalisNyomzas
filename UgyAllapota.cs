using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class UgyAllapota
    { // nem a legszebb de jó lesz ez így
        public string AktualisStatusz { get; private set; } 

        public UgyAllapota(string kezdoStatusz = "nyitott")
        {
            AktualisStatusz = kezdoStatusz;
        }

        public void AllapotValtas(string ujStatusz)
        {
            // ellenőrzés hogy csak "nyitott / folyamatban / lezárt" státuszokra lehessen váltani
            string[] validStatuszok = { "nyitott", "folyamatban", "lezárt" };

            if (Array.Exists(validStatuszok, s => s == ujStatusz.ToLower()))
            {
                AktualisStatusz = ujStatusz.ToLower();
            }
            else
            {
                Console.WriteLine("Hiba: Érvénytelen státusz!");
            }
        }

        public override string ToString()
        {
            return AktualisStatusz;
        }
    }
}
