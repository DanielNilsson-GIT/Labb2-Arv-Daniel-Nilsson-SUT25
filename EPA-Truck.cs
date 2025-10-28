using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class EPA_Truck:Car
    {

        public bool PlayEPADunk { get; set; }

        public EPA_Truck(string brand, string model, int noofwheels, string countryoforigin, int swemiles, int noofpreviousowners, bool hydralics, bool körförbud)
            : base(brand, model, noofwheels, countryoforigin, swemiles, noofpreviousowners, false)
        {
            Körförbud = körförbud;
        }
       

        public void playEpaDunk()
        {
            Console.WriteLine("Shitty musik spelas");
        }

        public override void startEngine()
        {
            base.startEngine();
            Console.WriteLine("Host host, splutt! (svart rök kommer)");
        }
        public override void VehicleInspection() 
        {
            Console.WriteLine("Till allas förvåning gick du igenom besiktningen och kan fortsätta förpesta vägarna. Grattis...");
            
        }
    }
}
