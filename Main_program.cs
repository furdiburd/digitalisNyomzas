namespace digitalisNyomzas
{
    internal class Main_program
    {
        static void Main(string[] args)
        {
            Adattar adattar = new Adattar();
            Ugykezelo ugykezelo = new Ugykezelo(adattar);
            BizonyitekKezeleo bizonyitekKezeleo = new BizonyitekKezeleo(adattar);
            DecisionEngine donteshozo = new DecisionEngine();

            bool kilepes = false;

            while (!kilepes)
            {
                Fomenu();
                Console.Write("Választás: ");
                string valasztas = Console.ReadLine();

                switch (valasztas)
                {
                    case "1": // Ügyek kezelése
                        UgyMenu(ugykezelo);
                        break;

                    case "2": // Személyek kezelése
                        SzemelyHozzaadasaMenu(ugykezelo);
                        break;

                    case "3": // Bizonyítékok kezelése
                        BizonyitekMenu(ugykezelo, bizonyitekKezeleo);
                        break;

                    case "4": // Idővonal
                        IdovonalMenu(ugykezelo, adattar);
                        break;

                    case "5": // Elemzés
                        ElemzesMenu(donteshozo, adattar);
                        break;

                    case "6":
                        kilepes = true;
                        break;

                    default:
                        Console.WriteLine("Érvénytelen választás.");
                        break;
                }
            }
        }
        // lehet felkellene töltenem adatokkal, de most ehhez nagyon nincs kedvem este

        static void Fomenu()
        {
            Console.WriteLine("\n=== DIGITÁLIS NYOMOZÁS ===");
            Console.WriteLine("1. Ügyek kezelése");
            Console.WriteLine("2. Személyek kezelése");
            Console.WriteLine("3. Bizonyítékok kezelése");
            Console.WriteLine("4. Idővonal megtekintése");
            Console.WriteLine("5. Elemzés / döntések");
            Console.WriteLine("6. Kilépés");
        }

        static void UgyMenu(Ugykezelo ugykezelo)
        {
            Console.WriteLine("\n--- Ügyek kezelése ---");
            Console.WriteLine("1. Új ügy");
            Console.WriteLine("2. Ügyek listázása");
            Console.WriteLine("3. Ügy állapotának módosítása");
            Console.Write("Választás: ");
            string valasztas = Console.ReadLine();

            switch (valasztas)
            {
                case "1":
                    Console.Write("Ügy azonosító: ");
                    string azonosito = Console.ReadLine();
                    Console.Write("Cím: ");
                    string cim = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    ugykezelo.UjUgy(azonosito, cim, leiras);
                    break;

                case "2":
                    ugykezelo.ListazUgyek();
                    break;

                case "3":
                    Console.Write("Ügy azonosító: ");
                    string ugyId = Console.ReadLine();
                    Console.Write("Új állapot (nyitott/folyamatban/lezárt): ");
                    string ujAllapot = Console.ReadLine();
                    ugykezelo.UgyAllapotModositas(ugyId, ujAllapot);
                    break;

                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }
        }

        static void SzemelyHozzaadasaMenu(Ugykezelo ugykezelo)
        {
            Console.Write("\nÜgy azonosító: ");
            string ugyAzonosito = Console.ReadLine();

            Console.Write("Név: ");
            string nev = Console.ReadLine();

			Console.Write("Életkor: ");
			int eletkor;
			while (!int.TryParse(Console.ReadLine(), out eletkor))
			{
				Console.WriteLine("Érvénytelen bemenet. Kérlek, add meg az életkort számként:");
				Console.Write("Életkor: ");
			}
			Console.Write("Megjegyzés: ");
            string megjegyzes = Console.ReadLine();

            Szemely szemely = new Szemely(nev, eletkor, megjegyzes);
            ugykezelo.SzemelyHozzaadasa(ugyAzonosito, szemely);
        }

        static void BizonyitekMenu(Ugykezelo ugykezelo, BizonyitekKezeleo bizonyitekKezeleo)
        {
            Console.WriteLine("\n--- Bizonyítékok kezelése ---");
            Console.WriteLine("1. Új bizonyíték rögzítése ügyhöz");
            Console.WriteLine("2. Bizonyítékok listázása");
            Console.Write("Választás: ");
            string valasztas = Console.ReadLine();

            switch (valasztas)
            {
                case "1":
                    Console.Write("Ügy azonosító: ");
                    string ugyAzonosito = Console.ReadLine();

                    Console.Write("Bizonyíték azonosító: ");
                    string azonosito = Console.ReadLine();
                    Console.Write("Típus: ");
                    string tipus = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    Console.Write("Megbízhatósági érték (1-5): ");
                    int megbizhatosag = int.Parse(Console.ReadLine());
                    Console.Write("Súly (pl. 0.5 - 2.0): ");
                    double suly = double.Parse(Console.ReadLine());

                    Bizonyitek bizonyitek = new Bizonyitek(azonosito, tipus, leiras, megbizhatosag, suly);
                    bizonyitekKezeleo.BizonyitekHozzaadas(bizonyitek);
                    ugykezelo.BizonyitekHozzaadasa(ugyAzonosito, bizonyitek);
					break;

                case "2":
                    bizonyitekKezeleo.Listazas();
                    break;

                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }
        }

        static void IdovonalMenu(Ugykezelo ugykezelo, Adattar adattar)
        {
            Console.WriteLine("\n--- Idővonal ---");
            Console.WriteLine("1. Esemény hozzáadása");
            Console.WriteLine("2. Idővonal megtekintése");
            Console.Write("Választás: ");
            string valasztas = Console.ReadLine();

            Console.Write("Ügy azonosító: ");
            string ugyAzonosito = Console.ReadLine();

            switch (valasztas)
            {
                case "1":
                    Console.Write("Esemény leírása: ");
                    string leiras = Console.ReadLine();
                    ugykezelo.IdovonalEsemenyHozzaadasa(ugyAzonosito, leiras);
                    break;

                case "2":
                    var ugy = adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
                    if (ugy != null && ugy.Idovonal.Count > 0)
                    {
                        Console.WriteLine("\n--- Idővonal ---");
                        foreach (var e in ugy.Idovonal)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nincs idővonal esemény.");
                    }
                    break;

                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }
        }

        static void ElemzesMenu(DecisionEngine donteshozo, Adattar adattar)
        {
            Console.Write("\nÜgy azonosító: ");
            string ugyAzonosito = Console.ReadLine();

            var ugy = adattar.Ugyek.Find(u => u.UgyAzonosito == ugyAzonosito);
            if (ugy == null)
            {
                Console.WriteLine("Hiba: Az ügy nem található.");
                return;
            }

            Console.Write("Gyanúsított neve: ");
            string nev = Console.ReadLine();
			Console.Write("Életkor: ");
			int eletkor;
			while (!int.TryParse(Console.ReadLine(), out eletkor))
			{
				Console.WriteLine("Érvénytelen bemenet. Kérlek, add meg az életkort számként:");
				Console.Write("Életkor: ");
			}
			Console.Write("Megjegyzés: ");
			string megjegyzes = Console.ReadLine();

            Szemely szemely = new Szemely(nev, eletkor, megjegyzes);
            Gyanusitott gyanusitott = new Gyanusitott(szemely, 0, "megfigyelt");

            donteshozo.GyanusitottsagiSzintFrissitese(gyanusitott, ugy.Bizonyitekok);
        }
    }
}
