namespace digitalisNyomzas
{
    internal class Main_program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digitális nyomzás");
            bool kilepes = false;
            while (!kilepes)
            {
                Console.Write("Kérem válasszon a menüpontok közül (1-5): ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Első menüpont");
                        break;
					case "2":

                    case "3":

                    case "4":

                    case "5":

                    default:
                        Console.WriteLine("Érvénytelen választás, kérem próbálja újra.");
                        break;
                }
                }
			}
        static void Menu()
        {
            Console.WriteLine("1. Bizonyitekkezelő");
            Console.WriteLine("2. Ügykezelő");
            Console.WriteLine("3. Döntéshozó");
            Console.WriteLine("4. Adattár");
            Console.WriteLine("5. Kilépés");
		}
	}
}
