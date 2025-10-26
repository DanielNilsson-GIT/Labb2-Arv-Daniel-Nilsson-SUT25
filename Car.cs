using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Car:Vehicle
    {

        public Car(string brand, string model, int noofwheels, string countryoforigin, int swemiles)
        {
            Brand = brand;
            Model = model;
            NoOfWheels = noofwheels;
            CountryOfOrigin = countryoforigin;
            SweMiles = swemiles;


        }

        public override void Honk()
        {
            Console.WriteLine("Beep beep.");
            Console.Beep();
        }
    }
}
