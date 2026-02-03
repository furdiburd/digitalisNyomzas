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

		public string Adattagok { get => adattagok; set => adattagok = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }
	}

    public class Felhasznalo
    {
        public string Nev { get; set; }
        public string Azonosito { get; set; }
        public string Szerepkor { get; set; }

        public Felhasznalo(string nev, string azonosito, string szerepkor)
        {
            Nev = nev;
            Azonosito = azonosito;
            Szerepkor = szerepkor;
        }

        public override string ToString()
        {
            return $"[{Azonosito}] {Nev} - {Szerepkor}";
        }
    }
}
