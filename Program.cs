
namespace LA_1200
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool loop = true;
            List<string> listenWorkshopNamen = new List<string>();
               WorkshopNamen workshopNamen = new();
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
        }
    }  
}