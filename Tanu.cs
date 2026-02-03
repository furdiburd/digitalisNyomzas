using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Tanu
    {
        public Szemely AlapAdatok { get; set; }
        public string VallomasSzovege { get; set; }
        public DateTime VallomasDatuma { get; set; }

        public Tanu(Szemely alapAdatok, string vallomasSzovege, DateTime vallomasDatuma)
        {
            AlapAdatok = alapAdatok;
            VallomasSzovege = vallomasSzovege;
            VallomasDatuma = vallomasDatuma;
        }

        public override string ToString()
        {
            return $"Tanú: {AlapAdatok.Nev} - Vallomás dátuma: {VallomasDatuma:yyyy.MM.dd}";
        }
    }
}
