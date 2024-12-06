using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal class Jagged_array
    {
        public Jagged_array()
        {
            Object[][] froutSize = new object[4][]; // different column size array

            froutSize[0] = new object[] {"Banana:", 5, 7, 9};
            froutSize[1] = new object[] { "Mango:", 1, 9 };
            froutSize[2] = new object[] { "Apple:", 5 };
            froutSize[3] = new object[] { "Malta:", 5, 7, 9, 5, 5, 9};

            foreach (object[] array in froutSize) {
                foreach (object item in array) {

                    Console.Write(item+", ");
                }
                Console.WriteLine();
            }


        }
    }
}
