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
        public int Miles { get; set; }

        public Vehicle(string brand, string model, int noofwheels, string countryoforigin, int miles)
        {
            Brand = brand;
            Model = model;
            NoOfWheels = noofwheels;
            CountryOfOrigin = countryoforigin;
            Miles = miles;

        }
        public void Drive()
        {

        }
    }
}
