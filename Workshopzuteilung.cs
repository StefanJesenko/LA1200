
namespace LA_1200
{
    class Workshopzuteilung
    {
        public int k = 0;
        public int i = 0;
        public List<int> kCount = new List<int>();
        public List<string> Workshopzuteilungen(List<string> teilnehmer, List<int> priorität, List<string> Workshops)
        {
            List<string> Zuteilung = new List<string>();
            List<string> finalZuteilung = new List<string>();
            int prioritätCount = 3;
            int zahlWorkshop = 0;
            Workshopzuteilung workshopzuteilung = new();
             
            
             int j = 0;
            
            for( int y = 0; y < Workshops.Count; y++)
            {
                workshopzuteilung.WorkshopzuteilungAlgorythmus(teilnehmer, priorität, Workshops, Zuteilung, prioritätCount, zahlWorkshop, j,i,k);
                i = 0;
                i++;
                k = 0;
                zahlWorkshop++;
                Zuteilung = new List<string>();
                foreach (string s in Zuteilung)
                {
                    finalZuteilung.Add(s);
                }
            }
            
            for ( int y = 0; y < Workshops.Count; y++)
            {
                k = 0;
                i = 0;
                zahlWorkshop = 0;
                j = 0;
                prioritätCount--;
                Zuteilung = new List<string>();
                for (int z = 0; z < kCount.Count; z++)
                {
                    if (kCount[z] != 4)
                    {
                        workshopzuteilung.WorkshopzuteilungAlgorythmus(teilnehmer, priorität, Workshops, Zuteilung, prioritätCount, zahlWorkshop, j, i, k);
                    }
                    else
                    {
                        break;
                    }
                }

                    i++;
                k = 0;
                zahlWorkshop++;
                foreach (string s in Zuteilung)
                {
                    finalZuteilung.Add(s);
                }
            }
            for( int y = 0; y < Workshops.Count; y++)
            {
                k = 0;
                i = 0;
                zahlWorkshop = 0;
                j = 0;
                prioritätCount--;
                Zuteilung = new List<string>();
                for(int z = 0 ; z < kCount.Count; z++)
                {
                    if(kCount[z] != 4)
                    {
                        workshopzuteilung.WorkshopzuteilungAlgorythmus(teilnehmer, priorität, Workshops, Zuteilung, prioritätCount, zahlWorkshop, j, i, k);
                    }
                    else
                    {
                        break;
                    }
                }
                  
                
                
                i++;
                k = 0;
                zahlWorkshop++;
                foreach (string s in Zuteilung)
                {
                    finalZuteilung.Add(s);
                }
            }
            foreach(string s in finalZuteilung)
            {
                Console.WriteLine(s);
            }
          

            return finalZuteilung;
        }
        
        public List<string> WorkshopzuteilungAlgorythmus(List<string> Teilnehmer, List<int> priorität, List<string>Workshops, List<string>Zuteilung, int prioritätCount, int zahlWorkshop, int j, int i, int k)
        {

           
            for (; i < priorität.Count; i += Workshops.Count)
            {

                if (priorität[i] == prioritätCount)
                {
                    Zuteilung.Add(Workshops[zahlWorkshop] + " " + Teilnehmer[j]);

                    k++;
                    if (k == 4)
                    {
                        kCount.Add(k);
                        break;
                    }
                }
                j++;
              
            }
           
            return Zuteilung;
        }
  
    }
}