using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Car:Vehicle
    {
        private bool Hydralics { get; set; } = false;
        public bool Trunkopen { get; set; } = false;

        public override string VehicleSound { get; set; } = "Brrr-brrr-brrr-vrooooom!";

        public Car():base()
        {

        }
        public Car(string brand, string model, int noofwheels, string countryoforigin, int swemiles,int noofpreviousowners,bool hydralics, bool körförbud)
            :base(brand,model,noofwheels,countryoforigin,swemiles,noofpreviousowners,false)
        {
            Hydralics = hydralics;
            
        }

        public void PopTheTrunk()
        {
            if (Trunkopen == false)
            {
            Trunkopen = true;
            Console.WriteLine("Du öppnade bagageluckan");

            }
            else
            {
                Trunkopen = false;
                Console.WriteLine("Du stängde bagageluckan.");
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Utrustad med hydralik? {Hydralics}");
            if (Trunkopen == true)
            {
                Console.WriteLine("\n...Glöm inte att stänga bagageluckan.");
            }
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
        public override void Honk()
        {
            Console.WriteLine("Beep beep.");
            Console.Beep();
        }
    }
}
