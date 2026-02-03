using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class IdovonalEsemeny
    {
        public DateTime Datum { get; set; }
        public string Leiras { get; set; }

        public IdovonalEsemeny(DateTime datum, string leiras)
        {
            Datum = datum;
            Leiras = leiras;
        }

        public override string ToString()
        {
            return $"{Datum:yyyy.MM.dd HH:mm} - {Leiras}";
        }
    }
}
