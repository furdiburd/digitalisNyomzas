using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Ugy
	{
		public string Adattagok;
        public string UgyAzonosito { get; set; }
        public string Cim { get; set; }
        public string Leiras { get; set; }
        public string Allapot { get; set; }
        public List<Szemely> Szemelyek { get; set; }
        public List<Bizonyitek> Bizonyitekok { get; set; }
        public List<IdovonalEsemeny> Idovonal { get; set; }

        public Ugy(string ugyAzonosito, string cim, string leiras)
        {
            UgyAzonosito = ugyAzonosito;
            Cim = cim;
            Leiras = leiras;
            Allapot = "nyitott";
            Szemelyek = new List<Szemely>();
            Bizonyitekok = new List<Bizonyitek>();
            Idovonal = new List<IdovonalEsemeny>();
        }

        public override string ToString()
        {
            return $"[{UgyAzonosito}] {Cim} ({Allapot})";
        }
    }
}
