namespace BudgetTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            BudgetManager manager = new BudgetManager();

            bool running = true;
            while(running)
            {
                //Skapar en meny
                Console.WriteLine("Välkommen till ditt BudgetTracker konto!");
                Console.ReadLine();
                Console.WriteLine("Vad vill du göra? Ange ett val nedan:");
                Console.WriteLine("1: Lägg till transaktion");
                Console.WriteLine("2: Visa alla transaktioner");
                Console.WriteLine("3: Visa total balans");
                Console.WriteLine("4: Ta bort transaktion");
                Console.WriteLine("5: Avsluta");
            }
            
        }
    }
}
