using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class BizonyitekKezeleo
    {
        private Adattar _adattar;

        public BizonyitekKezeleo(Adattar adattar)
        {
            _adattar = adattar;
        }

        public void BizonyitekHozzaadas(Bizonyitek bizonyitek)
        {
            _adattar.Bizonyitekok.Add(bizonyitek);
            Console.WriteLine("Bizonyíték sikeresen rögzítve a rendszerben.");
        }

        public void BizonyitekTörlése(string azonosito)
        {
            var item = _adattar.Bizonyitekok.FirstOrDefault(b => b.Azonosito == azonosito);
            if (item != null)
            {
                _adattar.Bizonyitekok.Remove(item);
                Console.WriteLine($"A(z) {azonosito} azonosítójú bizonyíték törölve.");
            }
            else
            {
                Console.WriteLine("Hiba: Ilyen azonosítóval nem található bizonyíték.");
            }
        }

        public void Listazas()
        {
            if (_adattar.Bizonyitekok.Count == 0)
            {
                Console.WriteLine("Nincsenek rögzített bizonyítékok.");
                return;
            }

            Console.WriteLine("\n--- Összes Bizonyíték ---");
            foreach (var b in _adattar.Bizonyitekok)
            {
                Console.WriteLine(b.ToString());
			}
        }
    }
}
