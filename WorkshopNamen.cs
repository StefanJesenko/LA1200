namespace LA_1200
{
    class WorkshopNamen
    {

        public void Display() 
        {
            Console.WriteLine("Hier können Sie Workshopnamen eingeben, wenn Sie keine weiteren Namen eingeben wollen geben Sie \"n\"ein");
        }
        public string Workshop()
        {
           
            Console.Write("Geben Sie einen Workshopnamen ein: ");
            string workshopNamen = Console.ReadLine();

            return workshopNamen;
        }
    }
    
}