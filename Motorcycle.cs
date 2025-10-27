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

        public Motorcycle(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners,bool partofgang,string gang)
            : base(brand, model, noofwheels, countryoforigin, swemiles, noofpreviousowners)
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
                Console.Write($" {Gang}\n");
                Console.ResetColor();
                
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
