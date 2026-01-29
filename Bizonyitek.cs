using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Bizonyitek
	{
		private string bizonyitek_azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosagi_ertek;

		public Bizonyitek(string bizonyitek_azonosito, string tipus, string leiras, int megbizhatosagi_ertek)
		{
			this.bizonyitek_azonosito = bizonyitek_azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagi_ertek = megbizhatosagi_ertek;
		}

		public string Bizonyitek_azonosito { get => bizonyitek_azonosito; set => bizonyitek_azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int Megbizhatosagi_ertek { get => megbizhatosagi_ertek; set => megbizhatosagi_ertek = value; }
	}
}
