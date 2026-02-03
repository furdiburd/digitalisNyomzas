using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Adattar
    {
        public List<Felhasznalo> Felhasznalok { get; set; }
        public List<Ugy> Ugyek { get; set; }
        public List<Szemely> Szemelyek { get; set; }
        public List<Bizonyitek> Bizonyitekok { get; set; }

        public Adattar()
        {
            Felhasznalok = new List<Felhasznalo>();
            Ugyek = new List<Ugy>();
            Szemelyek = new List<Szemely>();
            Bizonyitekok = new List<Bizonyitek>();
        }
    }
}
