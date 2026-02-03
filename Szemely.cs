using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Szemely
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Megjegyzes { get; set; }

        public Szemely(string nev, int életkor, string megjegyzes)
        {
            Nev = nev;
            Eletkor = életkor;
            Megjegyzes = megjegyzes;
        }

        public override string ToString()
        {
            return $"{Nev} ({Eletkor} éves) - {Megjegyzes}";
        }
    }
}
