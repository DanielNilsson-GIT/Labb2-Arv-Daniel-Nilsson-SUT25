using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Mobilehome : Car
    {
        public int NoOfPlatesAvailable { get; set; } = 10;
        public override string VehicleSound { get; set; } = "rrrrr-t-t-t-t brum";

        public Mobilehome(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners,bool hydralics, bool körförbud)
            :base(brand,model,noofwheels,countryoforigin,swemiles,noofpreviousowners,hydralics,körförbud)
        {
            
        }
        public void SetTable()
        {
            Console.WriteLine("Hur många ska du duka till?");
            int noOfGuests = 0;
            while (!int.TryParse(Console.ReadLine(), out noOfGuests)||noOfGuests <= 0)
            {
                Console.WriteLine("Skriv heltal:");
            }

            if (noOfGuests > NoOfPlatesAvailable)
            {
                Console.WriteLine("Du har inte tillräckligt med talrikar kvar.");
            }
            else 
            {
                Console.WriteLine("Du har dukat för " + noOfGuests + " gäster.");
                NoOfPlatesAvailable = NoOfPlatesAvailable - noOfGuests;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("Fordonsinformation:\n");
            Console.WriteLine($"Märke: {Brand}\nModell: {Model}\nAntal hjul: {NoOfWheels}\nLand: {CountryOfOrigin}\nMil: {SweMiles}\nAntal ägare: {NoOfPreviousOwners}");
            Console.Write("\nHar fordonet körförbud? ");
            if (Körförbud)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Körförbud);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Körförbud);
                Console.ResetColor();
            }
            Console.WriteLine("\n____________________________________________________________________________________\n");
        }
        

    }
}
