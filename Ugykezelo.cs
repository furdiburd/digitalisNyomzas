using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
    public class Ugykezelo
    {
        private Adattar _adattar;

        public Ugykezelo(Adattar adattar)
        {
            _adattar = adattar;
        }

        public void UjUgy(string azonosito, string cim, string leiras)
        {
            Ugy ujUgy = new Ugy(azonosito, cim, leiras);
            _adattar.Ugyek.Add(ujUgy);
            Console.WriteLine($"Ügy létrehozva: {cim}");
        }

        public void ListazUgyek()
        {
            if (_adattar.Ugyek.Count == 0)
            {
                Console.WriteLine("Nincsenek regisztrált ügyek.");
                return;
            }

            Console.WriteLine("\n--- Ügyek listája ---");
            foreach (var ugy in _adattar.Ugyek)
            {
                Console.WriteLine(ugy.ToString());
            }
        }

        public void SzemelyHozzaadasa(string ugyAzonosito, Szemely szemely)
        {
            Ugy ugy = _adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
            if (ugy != null)
            {
                ugy.Szemelyek.Add(szemely);
                Console.WriteLine($"{szemely.Nev} hozzáadva a(z) {ugy.Cim} ügyhöz.");
            }
            else
            {
                Console.WriteLine("Hiba: Az ügy nem található!");
            }
        }

        public void BizonyitekHozzaadasa(string ugyAzonosito, Bizonyitek bizonyitek)
        {
            Ugy ugy = _adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
            if (ugy != null)
            {
                if (ugy.Allapot == "lezárt")
                {
                    Console.WriteLine("Hiba: Lezárt ügyhöz nem adható bizonyíték!");
                    return;
                }

                ugy.Bizonyitekok.Add(bizonyitek);
                Console.WriteLine($"Bizonyíték ({bizonyitek.Azonosito}) hozzáadva az ügyhöz.");
            }
            else
            {
                Console.WriteLine("Hiba: Az ügy nem található!");
            }
        }

        public void UgyAllapotModositas(string ugyAzonosito, string ujAllapot)
        {
            Ugy ugy = _adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
            if (ugy != null)
            {
                ugy.Allapot = ujAllapot;
                Console.WriteLine($"Az ügy új állapota: {ujAllapot}");
            }
            else
            {
                Console.WriteLine("Hiba: Az ügy nem található!");
            }
        }

        public void IdovonalEsemenyHozzaadasa(string ugyAzonosito, string leiras)
        {
            Ugy ugy = _adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
            if (ugy != null)
            {
                ugy.Idovonal.Add(new IdovonalEsemeny(DateTime.Now, leiras));
                Console.WriteLine("Idővonal esemény hozzáadva.");
            }
            else
            {
                Console.WriteLine("Hiba: Az ügy nem található!");
            }
        }
    }
}