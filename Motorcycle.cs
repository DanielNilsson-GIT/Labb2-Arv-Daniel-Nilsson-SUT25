using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Motorcycle:Vehicle
    {

        public Motorcycle(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners)
            : base(brand, model, noofwheels, countryoforigin, swemiles, noofpreviousowners)
            
        {
           

        }
        public override void Honk()
        {
            Console.WriteLine("meeep mehp");
            Console.Beep(300, 1);
            Console.Beep(300, 1);
        }
    }
}
