using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Motorcycle : Vehicle
    {
        public bool PartOfGang { get; set; } = false;
        public string Gang { get; set; } = null;
        public override string VehicleSound { get; set; } = "Rr-rrr-vrroooom-vrroooom!";

        public Motorcycle(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners,bool partofgang,string gang)
            : base(brand, model, noofwheels, countryoforigin, swemiles, noofpreviousowners,false)
        {
            PartOfGang = partofgang;
            Gang = gang;
        }

       
        public void DoAWheelie()
        {
            Random rnd = new Random();
            int chance=rnd.Next(1, 101);
            
            if (chance<=30)
            {
                Console.WriteLine("Krasch!! Du kvadda bajken :(");
            }
            else
            {
                Console.WriteLine("Vroom! Wohoo");
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Tillhör gäng?: {PartOfGang}");
            if (PartOfGang)
            {
                Console.Write($"Gäng:");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" {Gang}");
                Console.ResetColor();
                Console.WriteLine("");
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
        public override void Honk()
        {
            Console.WriteLine("meeep mehp");
            Console.Beep(300, 1);
            Console.Beep(300, 1);
        }
    }
}
