using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Boat:Vehicle
    {
        public int NauticalMiles { get; set; } = 0;

        public override string VehicleSound { get; set; } = "Chug-chug-chug, Splutt-splutt, Blubb-blubb-vrooooom!";

        public Boat() : base()
        {

        }

       

        public Boat(string brand, string model, string countryoforigin, int nauticalmiles, int noofprevowners,bool körförbud): 
            base(brand,model,0,countryoforigin,0,noofprevowners,false)
        {
            NauticalMiles = nauticalmiles;
        }

     
        public override void Honk() 
        {
            Console.WriteLine("DOOOOOT!");
            Console.Beep(20,3);
        }

        public int KmToNautical(int newmiles)
        {
            double nautmiles = newmiles / 0.1852;
            int roundednautmiles = (int)Math.Round(nautmiles);
            return roundednautmiles;
        }

        public override int AddMiles()
        {
            int newmiles=KmToNautical(base.AddMiles());
            NauticalMiles = NauticalMiles + newmiles;
            return NauticalMiles;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Märke: {Brand}\nModell: {Model}\nLand: {CountryOfOrigin}\nSjömil: {NauticalMiles}\nAntal ägare: {NoOfPreviousOwners}");
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
