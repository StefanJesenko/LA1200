
namespace LA_1200
{
    class Workshopzuteilung
    {
        public int k = 0;
        public int i = 0;
        public List<int> kCount = new List<int>();
        public List<string> Workshopzuteilungen(List<string> participants, List<int> priority, List<string> workshop)
        {
            List<string> allocation  = new List<string>();
            List<string> finalAllocation = new List<string>();
            int priorityCount = 3;
            int numberWorkshop = 0;
            Workshopzuteilung workshopzuteilung = new();
             
            
             int j = 0;
            
            for( int y = 0; y < workshop.Count; y++)
            {
                workshopzuteilung.WorkshopzuteilungAlgorythmus(participants, priority, workshop, allocation, priorityCount, numberWorkshop, j,i,k);
                i = 0;
                i++;
                k = 0;
                numberWorkshop++;
               allocation = new List<string>();
                foreach (string s in allocation)
                {
                    finalAllocation.Add(s);
                }
            }
            
            for ( int y = 0; y < workshop.Count; y++)
            {
                k = 0;
                i = 0;
                numberWorkshop = 0;
                j = 0;
                priorityCount--;
                allocation = new List<string>();
                for (int z = 0; z < kCount.Count; z++)
                {
                    if (kCount[z] != 4)
                    {
                        workshopzuteilung.WorkshopzuteilungAlgorythmus(participants, priority, workshop, allocation, priorityCount, numberWorkshop, j, i, k);
                    }
                    else
                    {
                        break;
                    }
                }

                    i++;
                k = 0;
                numberWorkshop++;
                foreach (string s in allocation)
                {
                    finalAllocation.Add(s);
                }
            }
            for( int y = 0; y < workshop.Count; y++)
            {
                k = 0;
                i = 0;
                numberWorkshop = 0;
                j = 0;
                allocation = new List<string>();
                for(int z = 0 ; z < kCount.Count; z++)
                {
                    if(kCount[z] != 4)
                    {
                        workshopzuteilung.WorkshopzuteilungAlgorythmus(participants, priority, workshop, allocation, priorityCount, numberWorkshop, j, i, k);
                    }
                    else
                    {
                        break;
                    }
                }
                  
                
                
                i++;
                k = 0;
                numberWorkshop++;
                foreach (string s in allocation)
                {
                    finalAllocation.Add(s);
                }
            }
            foreach(string s in finalAllocation)
            {
                Console.WriteLine(s);
            }
          

            return finalAllocation;
        }
        
        public List<string> WorkshopzuteilungAlgorythmus(List<string> participants, List<int> priority, List<string>workshop, List<string> Allocation, int priorityCount, int numberWorkshop, int j, int i, int k)
        {

           
            for (; i < priority.Count; i += workshop.Count)
            {

                if (priority[i] == priorityCount)
                {
                    Allocation.Add(workshop[numberWorkshop] + " " + participants[j]);

                    k++;
                    if (k == 4)
                    {
                        kCount.Add(k);
                        break;
                    }
                }
                j++;
              
            }
           
            return Allocation;
        }
  
    }
}