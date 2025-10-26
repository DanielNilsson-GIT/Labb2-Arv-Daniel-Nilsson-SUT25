using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public string CountryOfOrigin { get; set; }
        public int SweMiles { get; set; }

        //public Vehicle(string brand, string model, int noofwheels, string countryoforigin, int swemiles)
        //{
        //    Brand = brand;
        //    Model = model;
        //    NoOfWheels = noofwheels;
        //    CountryOfOrigin = countryoforigin;
        //    SweMiles = swemiles;

        //}
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Märke: {Brand}\nModell: {Model}\nAntal hjul: {NoOfWheels}\nLand: {CountryOfOrigin}\nMil: {SweMiles}");
        }
        public virtual void Honk()
        {
            Console.WriteLine("Tuuuut!");
            Console.Beep();
        }
        public virtual int Drive()
        {

            Console.WriteLine("Hur många kilometer färdades du?");
            int kilometersDriven = 0;
            while (!int.TryParse(Console.ReadLine(), out kilometersDriven))
            {
                Console.WriteLine("Ange heltal (KM):");
            }

            SweMiles = SweMiles +(kilometersDriven/10);
            return kilometersDriven / 10;

        }
    }
}
