namespace LA_1200
{
    
    class WorkShopEinteilung
    {
        
        public List<string> teilnehmer = new List<string>();
        public  List<string> TeilnehmerNamen(List<string>Teilnehmer)
        {
            
       
            Console.WriteLine("Geben Sie den Vor- und Nachnamen eines Workshopteilnehmers ein.");
            string name = Console.ReadLine();
            Teilnehmer.Add(name);
            teilnehmer.Add(name);
            
            return Teilnehmer;
        }
        public  List<int> WorkshopEinteilung(List<string>workshopNamen,List<string>Teilnehmer)
        {
            WorkShopEinteilung workShopEinteilung = new WorkShopEinteilung();

            List<string> workshopausw = new();
            List<int> priorität = new();
            int[] prioVor = new int[3];
            int mindanz = workshopNamen.Count * 4;
            bool control = false;
            bool check = false;
            int z = 0;
            int t = 0;
            
            while (check == false)
            {

                while (mindanz > t || mindanz < t)
                {
                    
                    workShopEinteilung.TeilnehmerNamen(Teilnehmer);
                    
                    for (int i = 0; i < workshopNamen.Count; i++)
                    {
                        control = false;




                       
                        while(control == false)
                        {

                            if (z >= workshopNamen.Count)
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
                                control = false;
                            }
                            if (prioVor[i] < 1 || prioVor[i] > 3)
                            {
                                Console.WriteLine("Bitte geben sie nur eine Zahl zwischen 1-3 ein.");
                                control = false;
                            }
                            else
                            {
                                
                                
                                priorität.Add(prioVor[i]);
                                
                               
                                
                                    control = true;
                                
                            }
                           
                            
                        }
                       
                    }
                    t++;
                    if(t == mindanz +2)
                    {
                        t = mindanz;
                    }
                } 
                Console.WriteLine("Um weiter zu fahren drücken Sie (n) Ansonsten drücken Sie die Leertaste.");
                string eingabe = Console.ReadLine();
                if (eingabe == "n")
                {
                    check = true;
                }
                else
                {
                   
                    control = false;
                    t++;
                }
                
                
                
            } 
            return priorität;
        }
    }
}
