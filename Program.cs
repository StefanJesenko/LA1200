
namespace LA_1200
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            AddingToWorkshop addingToWorkshop = new();
            Workshopzuteilung workshopallocation = new();
            List<string> participants = new();
        bool isLoop = true;
            List<string> listWorkshopName = new List<string>();
               WorkshopNamen workshopName = new();
            workshopName.Display();
           while(isLoop == true)
           {
                string workshopsName = workshopName.Workshop(); 
                if(workshopsName == "n")
                {
                    break;
                }
                listWorkshopName.Add(workshopsName);
                
           }

            foreach (string s in listWorkshopName)
            {
                Console.WriteLine(s);
            }
            
            List<int> priority = addingToWorkshop.AddingToWorkshops(listWorkshopName,participants);
            
            

           
            workshopallocation.WorkshopAllications(participants, priority, listWorkshopName);
            
        }
    }
}
