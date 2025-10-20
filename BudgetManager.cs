using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
        public class BudgetManager
        {
            //Skapar en ny lista transactions
            private List<Transaction> transactions = new List<Transaction>();

            //Metod AddTransaction() som lägger till transaktioner i listan
            public void AddTransaction(Transaction t)
            {
                transactions.Add(t);
                Console.WriteLine("Transaktionen har lagts till!");
            }

            //Metod ShowAll() som visar om det finns transaktioner i listan o hur många
            public void ShowAll()
            {
                if (transactions.Count == 0)
                {
                    Console.WriteLine("Det finns inga transaktioner ännu.");
                    return;
                }

                Console.WriteLine("\n Alla transaktioner:\n");

                int index = 1; // räknare för numrering
                foreach (Transaction t in transactions)
                {
                    //Grön för inkomst, röd för utgift
                    if (t.Amount > 0)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write($"{index}. ");
                    t.ShowInfo();

                    Console.ResetColor();
                    //Index ökar med 1 varje varv
                    index++;
                }
            }

            //Metod CalculateBalance() delar in inkomster o utgifter o
            //räknar balance
            public void CalculateBalance()
            {
                //Deklarerar inkomst o utgift, startvärde 0
                decimal income = 0;
                decimal expenses = 0;
                //Loopar genom listan transactions
                foreach (Transaction t in transactions)
                //Om en transaktion i listan är mer än 0 är det en inkomst,
                //annars är det en utgift
                {
                    if (t.Amount > 0)
                        income += t.Amount;
                    else
                        expenses += t.Amount;
                }

                Console.WriteLine($"\nTotala inkomster: {income}");
                Console.WriteLine($"Totala utgifter: {expenses}");
                Console.WriteLine($"Balans: {(income + expenses)}");
            }

            //Metod DeleteTransaction() tar bort transaktioner
            public void DeleteTransaction()
            {
                //Visar transaktionerna i listan, om det inte finns transaktioner i listan
                //-avsluta
                ShowAll();

                if (transactions.Count == 0)
                {
                    Console.WriteLine("Det finns inga transaktioner.");
                    return;
                }

                Console.Write("\nAnge numret på transaktionen du vill ta bort: ");

                // Läs in index
                int index = Convert.ToInt32(Console.ReadLine());

                //Om index är mer än 0 o om index är mindre än antalet transaktioner i listan
                if (index > 0 && index <= transactions.Count)
                {
                    // Tar bort vald transaktion
                    transactions.RemoveAt(index - 1);
                    Console.WriteLine("Transaktionen har tagits bort.");
                }
                else
                {
                    Console.WriteLine("Ogiltigt nummer, försök igen!");
                }

            }

        }
    }

