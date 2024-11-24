using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();

            personObj.name = "Iman Saleh";
            personObj.age = 24;

            personObj.print();

            personObj.name = "Hasan Mahmud";
            personObj.age = 26;
            personObj.print();

            Console.ReadLine();

        }
    }

    class Person
    {
        public string name = "sdsd";
        public int age;


        public void print()
        {
            Console.WriteLine("My name is: "+name);
            Console.WriteLine("Age: "+age);
        }
    }
}
