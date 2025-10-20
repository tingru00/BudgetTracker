using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
        public class Transaction
        {
            //Deklarerar attribut med get/return för att kunna använda i BudgetManager
            public string Description;
            public decimal Amount;
            public string Category;
            public DateTime Date;

            //Konstruktor
            public Transaction(string description, decimal amount, string category, DateTime date)
            {
                Description = description;
                Amount = amount;
                Category = category;
                Date = date;
            }

            //Deklarerar metoden ShowInfo()
            public void ShowInfo()
            {
                Console.WriteLine($"{Description} | {Amount} | {Category} | {Date} |");
            }
        }

    }


