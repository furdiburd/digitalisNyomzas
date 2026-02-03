using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Gyanusitott
    {
        public Szemely Szemely { get; set; }
        public int GyanusitottsagiSzint { get; set; }
        public string Statusz { get; set; }

        public Gyanusitott(Szemely szemely, int gyanusitottsagiSzint, string statusz)
        {
            Szemely = szemely;
            GyanusitottsagiSzint = gyanusitottsagiSzint;
            Statusz = statusz;
        }

        public override string ToString()
        {
            return $"{Szemely.Nev} - Szint: {GyanusitottsagiSzint}% - Állapot: {Statusz}";
        }
    }
}