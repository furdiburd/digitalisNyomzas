using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Bizonyitek
    {
        public string Azonosito { get; set; }
        public string Tipus { get; set; }
        public string Leiras { get; set; }
        public int MegbizhatosagiErtek { get; set; }
        public double Suly { get; set; }

        public Bizonyitek(string azonosito, string tipus, string leiras, int megbizhatosagiErtek, double suly = 1.0)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Leiras = leiras;
            MegbizhatosagiErtek = megbizhatosagiErtek;
            Suly = suly;
        }

        public override string ToString()
        {
            return $"[{Azonosito}] {Tipus}: {Leiras} (Megbízhatóság: {MegbizhatosagiErtek}/5, Súly: {Suly})";
        }
    }
}
