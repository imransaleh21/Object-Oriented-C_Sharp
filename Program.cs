using System;

namespace C__Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation Obj = new Encapsulation();               // encapsulation class

            //Obj.SetData("Iman Saleh",300000.00,25);
            //Obj.print();

            //Obj.SetData("Salman Khan",250000.00);
            //Console.WriteLine("Name: "+Obj.GetName());

            GetSetProperties Obj1 = new GetSetProperties();       // Get Set method class
            //Obj1.Name = "Imran Saleh"; // Read Only properties
            //Obj1.ID = 5; read only

            Obj1.Age = 25;
            Obj1.Salary = 35000.50;
            ParentPrint(Obj1);

            Obj1.Age = 24;
            Obj1.Salary = 30000.00;
            ParentPrint(Obj1);

            Jagged_array Obj2 = new Jagged_array();              //Jagged Array class
            params_as_method_parameter Obj3 = new params_as_method_parameter();
            Obj3.sum();
            Obj3.sum(1);
            Obj3.sum(1,2,3);
            Obj3.sum(1,2,3,4,5,6,7,8,9);
            Console.WriteLine();

            new Access_Static_Constractor(); // call the constractor of the class

            // the below code is for nested class
            Console.WriteLine();
            Vehicle vehicle = new Vehicle();
            Vehicle.Bike bike = new Vehicle.Bike();
            bike.ShowWheel();
            Vehicle.Bus bus = new Vehicle.Bus();
            bus.ShowWheel();

            //sealed function
            MiniBus miniBus = new MiniBus();
            miniBus.VehicleName("MiniBus");

            Console.ReadLine();
        }

        static void ParentPrint(GetSetProperties Obj1)
        {
            //Console.WriteLine("ID: "+ Obj1.ID);
            Console.WriteLine("Name: " + Obj1.Name);
            //Console.WriteLine("Age: "+Obj1.Age); //write only properties. Cannot Read
            Console.WriteLine("Salary: " + Obj1.Salary);
            Console.WriteLine();
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
