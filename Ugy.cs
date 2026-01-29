using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Ugy
	{
		private string adattagok;
		private string ugy_azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Felhasznalo> kapcsolodoSzemelyek;
		private List<Bizonyitek> bizonyitekok;

		public Ugy(string adattagok, string ugy_azonosito, string cim, string leiras, string allapot, List<Felhasznalo> kapcsolodoSzemelyek, List<Bizonyitek> bizonyitekok)
		{
			this.adattagok = adattagok;
			this.ugy_azonosito = ugy_azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.kapcsolodoSzemelyek = kapcsolodoSzemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		public global::System.String Adattagok { get => adattagok; set => adattagok = value; }
		public global::System.String Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
		public global::System.String Cim { get => cim; set => cim = value; }
		public global::System.String Leiras { get => leiras; set => leiras = value; }
		public global::System.String Allapot { get => allapot; set => allapot = value; }
		public List<Felhasznalo> KapcsolodoSzemelyek { get => kapcsolodoSzemelyek; set => kapcsolodoSzemelyek = value; }
		public List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
