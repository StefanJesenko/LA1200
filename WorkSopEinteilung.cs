namespace WhorkshopEinteilung
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> workshop = new();
            List<string> workshopTeil = new();
            List<string> workshopausw = new();
            List<int> workshopauswprio = new();
            int mindanz = workshop.Count * 4;
            bool control = false;
            bool check = false;
            int z = 1;
            do
            {
                do
                {
                    Console.WriteLine("Geben Sie den Vor- und Nachnamen eines Workshopteilnehmers ein.");
                    workshopTeil.Add(Convert.ToString(Console.ReadLine()));

                    for (int i = 0; i <= 3;)
                    {
                        i++;
                        Console.WriteLine("Geben Sie ein welcher Workshop Sie besuchen wollen.");
                        workshopausw.Add(Convert.ToString(Console.ReadLine()));
                        do
                        {
                            try
                            {
                                Console.WriteLine("Geben Sie ein welche Priorität Workshop {0} hat (1-3)", z);
                                workshopauswprio.Add(Convert.ToInt32(Console.ReadLine()));
                            }
                            catch
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                control = false;
                                i--;
                            }
                            if (workshopauswprio[i] > 3 || workshopauswprio[i] < 1)
                            {
                                Console.WriteLine("Bitte geben sie nur eine Zahl zwischen 1-3 ein.");
                                control = false;
                                i--;
                            }
                            else
                            {
                                z++;
                                control = true;
                            }
                        } while (control == false);
                    }
                } while (mindanz == workshopTeil.Count);
                Console.WriteLine("Um weiter zu fahren drücken Sie (n) Ansonst geben Sie weitere Teilnehmern ein.");
                string eingabe = Console.ReadLine();
                if (eingabe != "n")
                {
                    check = true;
                }
            } while (check == true);
        }
    }
}
