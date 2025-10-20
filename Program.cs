namespace BudgetTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            BudgetManager manager = new BudgetManager();

            bool running = true;
            while (running)
            {
                //Skapar en meny
                Console.WriteLine("Välkommen till ditt BudgetTracker konto!");
                Console.ReadLine();
                Console.WriteLine("Vad vill du göra? Ange ett val nedan:");
                Console.ReadLine();
                Console.WriteLine("1: Lägg till transaktion");
                Console.WriteLine("2: Visa alla transaktioner");
                Console.WriteLine("3: Visa total balans");
                Console.WriteLine("4: Ta bort transaktion");
                Console.WriteLine("5: Avsluta");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Beskrivning: ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Kategori: ");
                        string category = Console.ReadLine();

                        Console.WriteLine("Belopp: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Datum: (YYYY-MM-DD)");
                        DateTime date = Convert.ToDateTime(Console.ReadLine());

                        //Skapa ett Transaction objekt
                        Transaction t = new Transaction(description, amount, category, date);
                        //Lägg till i BudgetManager listan
                        manager.AddTransaction(t);
                        break;

                    case "2":
                        manager.ShowAll();
                        break;
                    case "3":
                        manager.CalculateBalance();
                        break;
                    case "4":
                        manager.DeleteTransaction();
                        break;
                    case "5":
                        Console.WriteLine("Programmet avslutas..");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
