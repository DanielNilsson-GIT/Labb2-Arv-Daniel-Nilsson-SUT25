using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Car:Vehicle
    {
        public bool Hydralics { get; set; } = false;
        public bool Trunkopen { get; set; } = false;

        public Car()
        {

        }
        public Car(string brand, string model, int noofwheels, string countryoforigin, int swemiles,int noofpreviousowners,bool hydralics)
            :base(brand,model,noofwheels,countryoforigin,swemiles,noofpreviousowners)
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
        }
        public override void Honk()
        {
            Console.WriteLine("Beep beep.");
            Console.Beep();
        }
    }
}
