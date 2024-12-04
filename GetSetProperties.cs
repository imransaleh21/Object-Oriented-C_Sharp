using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal class GetSetProperties
    {
        // below code line is for Read only properties 
        public string Name { get; } = "Imran Saleh";
        public readonly int ID = 4;

        private int age;
        public int Age
        { set { age = value; } }

        public double Salary { get; set; }
    }
}
