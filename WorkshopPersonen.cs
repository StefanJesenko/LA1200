
namespace LA_1200
{
    public class EingabePersonen 
    {
         public static string EingabePer(string Personen, int aznzahl)
        {
            List<string> personen = new List<string>();
            List<string> kurs = new List<string>();
            List<int> prio = new List<int>();
            int y = -1;
            string eingabe = "";
            start:
            do
            {
                y++;
                Console.WriteLine("Geben Sie die Teilnehmer ein");
                personen[y] = (Console.ReadLine());
                Console.WriteLine("Geben Sie ein in welcher Kurs sie sind");
                kurs[y] = (Console.ReadLine());
                Console.WriteLine("Geben Sie die Priorität ein");
                prio[y] = Convert.ToInt32(Console.ReadLine());
            } while (y <= 4);

                Console.WriteLine("Um weiter zu fahren drücken Sie (n) Ansonst geben Sie weitere Namen ein.");
                eingabe = Console.ReadLine();
            if (eingabe != "n")
            {
                goto start;
            }

            return Personen;
            
            

        }

    }
}
