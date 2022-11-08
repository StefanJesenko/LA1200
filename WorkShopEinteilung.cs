namespace WhorkshopEinteilung
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> Workshops = new();
            List<string> Teilnehmer = new();
            List<string> workshopausw = new();
            List<int> priorität = new();
            int[] prioVor = new int[3];
            int mindanz = Workshops.Count * 4;
            bool control = false;
            bool check = false;
            int z = 0;
            do
            {
                do
                {
                    Console.WriteLine("Geben Sie den Vor- und Nachnamen eines Workshopteilnehmers ein.");
                    Teilnehmer.Add(Console.ReadLine());
                    for (int i = 0; i < 3; i++)
                    {
                        z = 0;
                        z++;
                        Console.WriteLine("Geben Sie ein welcher Workshop Sie besuchen wollen.");
                        workshopausw.Add(Console.ReadLine());
                        do
                        {
                            try
                            {
                                control = true;
                                Console.WriteLine("Geben Sie ein welche Priorität Workshop {0} hat (1-3)", z);
                                prioVor[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                control = false;
                            }
                            if (prioVor[i] < 1 || prioVor[i] > 3)
                            {
                                Console.WriteLine("Bitte geben sie nur eine Zahl zwischen 1-3 ein.");
                                control = false;
                            }
                            else
                            {
                                control = true;
                                priorität.Add(prioVor[i]);
                            }
                        } while (control == false);
                    }
                } while (mindanz == Teilnehmer.Count);
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
