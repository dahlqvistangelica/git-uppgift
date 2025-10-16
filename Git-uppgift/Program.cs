namespace Git_uppgift
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static List<string> inventory = new List<string>(); 
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Fabrikshanteringssystemet!"); while (true)
            {
                Console.WriteLine("\nVälj en åtgärd:"); Console.WriteLine("1. Lägg till produkt"); Console.WriteLine("2. Visa inventarie"); Console.WriteLine("3. Ta bort produkt"); Console.WriteLine("4. Avsluta"); string val = Console.ReadLine(); switch (val)
                {
                    case "1":
                        LäggTillProdukt();
                        break;
                    case "2": VisaInventarie(); break;
                    case "3":
                        string userInput = Console.ReadLine();
                        TaBortProdukt(userInput);
                        break;
                    case "4": return;
                    default: Console.WriteLine("Ogiltigt val. Försök igen."); break;
                }
            }
        }
        static void LäggTillProdukt()
        {
            while (true)
            {
                Console.Write("Ange namn på produkten: ");
                string productName = Console.ReadLine();
                
                if(string.IsNullOrEmpty(productName))
                    Console.WriteLine("Du måste ange ett namn");

                inventory.Add(productName);
                
                Console.WriteLine($"{productName} är tillagd.");
                break;
            }
        }
        static void TaBortProdukt(string productToRemove)
        {
            inventory.Remove(productToRemove);
        }
        static void VisaInventarie()
        { // TODO: Implementera metod för att visa inventarie
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }



        }
    }
}