using System;

namespace C__Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation Obj = new Encapsulation();

            Obj.SetData("Iman Saleh",300000.00,25);
            Obj.print();

            Obj.SetData("Salman Khan",250000.00);
            Console.WriteLine("Name: "+Obj.GetName());

            Console.ReadLine();

        }
    }

    class Encapsulation
    {
        private static string name;
        private static int age;
        private static double salary;

        public void SetData(string n, double s, int a = 0) //writable
        {
            name = n;
            age = a;
            salary = s;
        }

        public string GetName() //readable
        {
            return name;
        }

        public double GetSalary() //readable
        {
            return salary;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine();
        }
    }
}
