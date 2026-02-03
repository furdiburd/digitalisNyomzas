using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class DecisionEngine
    {
        private const int KUSZOBERTEK = 75; // figyelmeztetés küszöbértéke

        public void GyanusitottsagiSzintFrissitese(Gyanusitott gyanusitott, List<Bizonyitek> bizonyitekok)
        {
            double osszSulyozottErtek = 0;

            foreach (var b in bizonyitekok)
            {
                osszSulyozottErtek += b.MegbizhatosagiErtek * b.Suly;
            }

            // ne legyen 100 fölött súlyozás után
            int ujSzint = (int)Math.Min(100, osszSulyozottErtek * 2.5);
            gyanusitott.GyanusitottsagiSzint = ujSzint;

            Console.WriteLine($"{gyanusitott.Szemely.Nev} új gyanúsítottsági szintje: {ujSzint}%");

            if (ujSzint >= KUSZOBERTEK)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Figyelmeztetés: A(z) {gyanusitott.Szemely.Nev} gyanúsítottsági szintje kritikus ({ujSzint}%) !");
                Console.ResetColor();
            }
        }

        public string ElemzoOsszegzes(Ugy ugy)
        {
            string osszegzes = $"--- Elemzői összefoglaló: {ugy.Cim} ---\n";
            osszegzes += $"Státusz: {ugy.Allapot}\n";
            osszegzes += $"Bizonyítékok száma: {ugy.Bizonyitekok.Count}\n";

            return osszegzes;
        }
    }
}
