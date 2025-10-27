using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; } = "Unknown";
        public string Model { get; set; } = "Unassigned";
        public int NoOfWheels { get; set; } = 0;
        public string CountryOfOrigin { get; set; } = "Unknown";
        public int SweMiles { get; set; } = 0;
        public int NoOfPreviousOwners { get; set; } = 0;
        public bool Körförbud { get; set; } = false;


        public Vehicle()
        {

        }

        public Vehicle(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners, bool körförbud)
        {
            Brand = brand;
            Model = model;
            NoOfWheels = noofwheels;
            CountryOfOrigin = countryoforigin;
            SweMiles = swemiles;
            NoOfPreviousOwners = noofpreviousowners;
            Körförbud = körförbud;
        }

        public virtual void VehicleInspection()
        {
            Console.WriteLine("Hur gammalt är ditt fordon? Ange antal år:");
            int yearsOld;
            while (!int.TryParse(Console.ReadLine(), out yearsOld) || yearsOld < 0)
            {
                Console.WriteLine("Ange heltal. Försök igen:");
            }

            Random rnd = new Random();
            int chance = rnd.Next(1, 101);

            if (yearsOld < 10)
            {
                if (chance > 30)
                {
                    Console.WriteLine("Du klarade besiktningen");
                    Körförbud = false;
                }
                else
                {
                    Console.WriteLine("Du klarade inte besiktningen tyvärr");
                    Körförbud = true;
                }

            }
            else if (yearsOld > 10)
            {
                if (chance > 50)
                {
                    Console.WriteLine("Du klarade besiktningen");
                    Körförbud = false;
                }
                else
                {
                    Console.WriteLine("Du klarade inte besiktningen.. Fixa eller skrota");
                    Körförbud = true;
                }
            }
            else if (yearsOld > 30)
            {
                if (chance > 70)
                {
                    Console.WriteLine("Du klarade besiktningen med nöd och näppe");
                    Körförbud = false;
                }
                else
                {
                    Console.WriteLine("Du klarade inte besiktningen.. Föga förvånande");
                    Körförbud = true;
                }
            }
            else
            {
                if (chance > 95)
                {
                    Console.WriteLine("Du klarade mirakulöst nog besiktningen!! Köp en lott!");
                    Körförbud = false;
                }
                else
                {
                    Console.WriteLine("Förväntade du dig att det skulle gå? skrota skiten");
                    Körförbud = true;
                }
            }

        }
        public virtual void startEngine()
        {
            Console.WriteLine("Nyckel vrids...");
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Märke: {Brand}\nModell: {Model}\nAntal hjul: {NoOfWheels}\nLand: {CountryOfOrigin}\nMil: {SweMiles}\nAntal ägare: {NoOfPreviousOwners}\nHar fordonet körförbud? {Körförbud}");
        }
        public virtual void Honk()
        {
            Console.WriteLine("Tuuuut!");
            Console.Beep();
        }
        public virtual int AddMiles()
        {

            Console.WriteLine("Hur många kilometer färdades du?");
            int kilometersDriven = 0;
            while (!int.TryParse(Console.ReadLine(), out kilometersDriven))
            {
                Console.WriteLine("Ange heltal (KM):");
            }

            SweMiles = SweMiles + (kilometersDriven / 10);
            return kilometersDriven / 10;

        }
    }
}
