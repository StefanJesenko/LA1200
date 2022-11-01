namespace LA_1200
{
    class WorkshopNamen
    {

        public void Display() 
        {
            Console.WriteLine("Hier können Sie Gruppennamen eingeben, wenn Sie keine weiteren Namen eingeben wollen geben Sie \"n\"ein");
        }
        public string Workshop()
        {
           
            Console.Write("Geben Sie einen Namen ein: ");
            string workshopNamen = Console.ReadLine();






            return workshopNamen;
        }
    }
    
}