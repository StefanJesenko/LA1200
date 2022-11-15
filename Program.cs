
namespace LA_1200
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            WorkShopEinteilung workShopEinteilung = new();
            Workshopzuteilung workshopzuteilung = new();
            List<string> Teilnehmer = new();
        bool loop = true;
            List<string> listenWorkshopNamen = new List<string>();
               WorkshopNamen workshopNamen = new();
            workshopNamen.Display();
           while(loop == true)
           {
                string workshopName = workshopNamen.Workshop(); 
                if(workshopName == "n")
                {
                    break;
                }
                listenWorkshopNamen.Add(workshopName);
                
           }

            foreach (string s in listenWorkshopNamen)
            {
                Console.WriteLine(s);
            }
            
            List<int> priorität = workShopEinteilung.WorkshopEinteilung(listenWorkshopNamen,Teilnehmer);
            
            

           
            workshopzuteilung.Workshopzuteilungen(Teilnehmer, priorität, listenWorkshopNamen);
            
        }
    }
}