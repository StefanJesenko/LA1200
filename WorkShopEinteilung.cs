namespace LA_1200
{
    
    class AddingToWorkshop
    {
        
        public List<string> participants = new List<string>();
        public  List<string> TeilnehmerNamen(List<string>Participants)
        {
            
       
            Console.WriteLine("Geben Sie den Vor- und Nachnamen eines Workshopteilnehmers ein.");
            string name = Console.ReadLine();
            Participants.Add(name);
            participants.Add(name);
            
            return Participants;
        }
        public List<int> AddingToWorkshops(List<string>workshopName,List<string>Participants)
        {
            AddingToWorkshop addingToWorkshop = new AddingToWorkshop();

            List<string> workshopausw = new();
            List<int> priority = new();
            int[] prioVor = new int[3];
            int minNumber = workshopName.Count * 4;
            bool isControl = false;
            bool isCheck = false;
            int z = 0;
            int t = 0;
            
            while (isCheck == false)
            {

                while (minNumber > t || minNumber < t)
                {
                    
                    addingToWorkshop.TeilnehmerNamen(Participants);
                    
                    for (int i = 0; i < workshopName.Count; i++)
                    {
                        isControl = false;




                       
                        while(isControl == false)
                        {

                            if (z >= workshopName.Count)
                            {
                                z = 0;
                            }
                            z++;
                            try
                            {
                                
                                Console.WriteLine("Geben Sie ein welche Priorität Workshop {0} hat (1-3)", z);
                                prioVor[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Ungültige Eingabe");
                                isControl = false;
                            }
                            if (prioVor[i] < 1 || prioVor[i] > 3)
                            {
                                Console.WriteLine("Bitte geben sie nur eine Zahl zwischen 1-3 ein.");
                                isControl = false;
                            }
                            else
                            {
                                
                                
                                priority.Add(prioVor[i]);
                                
                               
                                
                                    isControl = true;
                                
                            }
                           
                            
                        }
                       
                    }
                    t++;
                    if(t == minNumber+2)
                    {
                        t = minNumber;
                    }
                } 
                Console.WriteLine("Um weiter zu fahren drücken Sie (n) Ansonsten drücken Sie die Leertaste.");
                string eingabe = Console.ReadLine();
                if (eingabe == "n")
                {
                    isCheck = true;
                }
                else
                {
                   
                    isControl = false;
                    t++;
                }
                
                
                
            } 
            return priority;
        }
    }
}
