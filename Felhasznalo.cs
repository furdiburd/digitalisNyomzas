using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Felhasznalo
	{
		private string adattagok;
		private string nev;
		private string azonosito;
		private string szerepkor;

		public Felhasznalo(string adattagok, string nev, string azonosito, string szerepkor)
		{
			this.adattagok = adattagok;
			this.nev = nev;
			this.azonosito = azonosito;
			this.szerepkor = szerepkor;
		}

		public string Adattagok { get => adattagok; set => adattagok = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }
	}
}
