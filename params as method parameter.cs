using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal class params_as_method_parameter
    {
        public void sum(params int[] num)
        {
            int ans = 0;
            foreach (var i in num) 
            {
                ans += i;
            }
            Console.WriteLine($"Total for {num.Length} length array is: " + ans);
        }
    }
}
