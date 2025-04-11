using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal class Static_Constractor_Call
    {
        private static int  number;  
        internal Static_Constractor_Call()
        {
            Console.WriteLine("Number: "+ number);
            number = 5;
        }
        static Static_Constractor_Call() // this static constractor will call first
        {
            Console.WriteLine("This static constractor will run always");
            number = 15;
        }
        public static void numberShow()
        {
            Console.WriteLine("Static Constractor Number value Change: "+ number);
        }
    }

    internal class Access_Static_Constractor
    {
        internal Access_Static_Constractor()
        {
            //Static_Constractor_Call SCC = new Static_Constractor_Call();
            // if we do not create any object then only the value of static constractor will assign
            Static_Constractor_Call.numberShow(); 
        }
        
    }

}
