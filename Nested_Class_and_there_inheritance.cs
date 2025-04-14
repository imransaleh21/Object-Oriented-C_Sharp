using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal abstract class VehicaleParts
    {
        public abstract void ShowWheel();
    }
    
    internal class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("These Vehicles have engine");
        }
        internal class Bike : VehicaleParts
        {
           public override void ShowWheel()
            {
                Console.WriteLine("Bikes have Two Wheels");
            }
        }

        internal class Bus : VehicaleParts
        {
            public override void ShowWheel()
            {
                Console.WriteLine("Buses have Four Wheels");
            }
        }
    }
}
