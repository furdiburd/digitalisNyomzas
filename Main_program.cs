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
    }
}
