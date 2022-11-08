
namespace LA_1200
{
    class Workshopzuteilung
    {
         
        public List<string> Workshopzuteilungen()
        {
           
            List<string> Zuteilung = new List<string>();
            
            List<string> Workshops = new List<string>()
            {
              "Fischen", "Wandern", "Sky fahren"
            };
            List<string> Teilnehmer = new List<string>()
            {
                "Hans", "Ueli", "Peter", "Jürgen", "Biebidi", "Alla", "Jasdfasd", "Wut", "aewr", "weqr", "qwerqetewrt", "lul"
            };
            List<int> priorität = new List<int>()
            {
                3, 2, 1, 2, 1, 3, 3, 1, 2, 3, 1, 2, 1, 2, 1, 2, 1, 3, 1, 2, 3, 3, 1, 2, 3, 2, 1, 3, 1, 2, 1, 3, 2, 2, 3, 1 
            };
            int k = 0;
            int j = 0;
            for (int i = 0; i < priorität.Count; i += 3)
            {

                if (priorität[i] == 3)
                {
                    Zuteilung.Add(Workshops[0] + " " + Teilnehmer[j]);
                    
                    k++;
                    if (k == 4)
                    {
                        break;
                    }
                }
                j++;

            }
            j = 0;
            int p = k;

            for (int i = 1; i < priorität.Count; i += 3)
            {
                k += 4;
                if (priorität[i] == 3)
                {
                    Zuteilung.Add(Workshops[1] + " " + Teilnehmer[j]);
                    
                    p++;
                    if (p == k)
                    {
                        break;
                    }
                }
                j++;

            }
            j = 0;
            int q = p;
            for (int i = 2; i < priorität.Count; i += 3)
            {

                p += 4;
                if (priorität[i] == 3)
                {
                    Zuteilung.Add(Workshops[2] + " " + Teilnehmer[j]);
                   
                    q++;
                    if (q == p)
                    {
                        break;
                    }
                }
                j++;

            }
           

            if (k != 52)
            {
                k = 0;
                j = 0;
                for (int i = 0; i < priorität.Count; i += 3)
                {

                    if (priorität[i] == 2)
                    {
                        Zuteilung.Add(Workshops[0] + " " + Teilnehmer[j]);
                       
                        k++;
                        if (k == 4)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            else
            {
                k = 52;
            }
            
            j = 0;
             
            if(p != 54)
            {
               
                p = k;
                for (int i = 1; i < priorität.Count; i += 3)
                {
                    k += 4;
                    if (priorität[i] == 2)
                    {
                        Zuteilung.Add(Workshops[1] + " " + Teilnehmer[j]);
                        
                        p++;
                        if (p == k)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            else
            {
                p = 54;
            }
            
            j = 0;
             
            if(q != 9)
            {
                q = p;
                for (int i = 2; i < priorität.Count; i += 3)
                {

                    p += 4;
                    if (priorität[i] == 2)
                    {
                        Zuteilung.Add(Workshops[2] + " " + Teilnehmer[j]);
                        
                        q++;
                        if (q == p)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            if (k != 52)
            {
                k = 0;
                j = 0;
                for (int i = 0; i < priorität.Count; i += 3)
                {

                    if (priorität[i] == 1)
                    {
                        Zuteilung.Add(Workshops[0] + " " + Teilnehmer[j]);
                        
                        k++;
                        if (k == 4)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            else
            {
                k = 4;
            }

            j = 0;
            
            if (p != 8)
            {
                p = k;
                
                for (int i = 1; i < priorität.Count; i += 3)
                {
                    k += 4;
                    if (priorität[i] == 1)
                    {
                        Zuteilung.Add(Workshops[1] + " " + Teilnehmer[j]);
                        
                        p++;
                        if (p == k)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            else
            {
                p = 8;
            }

            j = 0;
           

            if (q != 12)
            {
                q = p;
                
                for (int i = 2; i < priorität.Count; i += 3)
                {

                    p += 4;
                    if (priorität[i] == 1)
                    {
                        Zuteilung.Add(Workshops[2] + " " + Teilnehmer[j]);
                        
                        q++;
                        if (q == p)
                        {
                            break;
                        }
                    }
                    j++;

                }
            }
            for (int i = 0; i < Teilnehmer.Count; i++)
            {
                Console.WriteLine(Zuteilung[i]);
            }














            return Zuteilung;
        }
       
        
           
        
        
        
    }
}