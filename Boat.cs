using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Boat:Vehicle
    {
        public int NauticalMiles { get; set; }


        public Boat(string brand, string model, int noofwheels, string countryoforigin, int nauticalmiles, int noofprevowners): 
            base(brand,model,noofwheels,countryoforigin,0,noofprevowners)
        {
            NauticalMiles = nauticalmiles;
        }

        public override void Honk()
        {
            Console.WriteLine("DOOOOOT!");
            Console.Beep(20,3);
        }
        public override int DistanceDriven()
        {
            double nautmiles= base.DistanceDriven()/0.1852;
            int roundednautmiles=(int)Math.Round(nautmiles);
            return roundednautmiles;

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Märke: {Brand}\nModell: {Model}\nAntal hjul: {NoOfWheels}\nLand: {CountryOfOrigin}\nSjömil: {NauticalMiles}\n Antal ägare: {NoOfPreviousOwners}");
        }
    }
}
