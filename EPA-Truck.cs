using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class EPA_Truck:Car
    {

        public bool PlayEPADunk { get; set; }

        public EPA_Truck() : base()
        {

        }

        public void playEpaDunk()
        {
            Console.WriteLine("Shitty musik spelas");
        }

        public override void VehicleInspection()
        {
            Console.WriteLine("Till allas förvåning gick du igenom besiktningen och kan fortsätta förpesta vägarna. Grattis...");
            
        }
    }
}
