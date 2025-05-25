using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    // if we scaled a class then the class cann't inherite
    // also if we scaled a method then the method cann't be override
    sealed internal class Sealed_Class_and_Method //this class cann't inherite
    {
        internal int price = 5;

        internal void show()
        {
            Console.WriteLine("Initial Price: " + price);
        }

    }

    class Bus
    {
        internal virtual void VehicleName(string name) 
        {
            Console.WriteLine("Name of the Vehicle Iz "+name);
        }
    }

    class MiniBus:Bus
    {
        internal sealed override void VehicleName(string name) //this method cann't override further
        {
            //base.VehicleName(name);
            Console.WriteLine("\nName of the Vehicle is " + name);
        }
    }
}
