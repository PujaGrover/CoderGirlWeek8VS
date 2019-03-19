using System;

namespace Week8PrepWorkObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethod();  //Example of Static keyword method created towards the end of this program
            //myCar.Make = "Oldsmobile";
            //myCar.Model = "Cutlas Supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";

            //Car myOtherCar;
            //myOtherCar = myCar;

            ////Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            //myOtherCar.Model = "98";
            //Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
              
            //myOtherCar = null;
            //// null Will remove the referance of this object to myCar. This will object will be reoved
            ////by .Net framework at sometime.This can also be forcefully removed by the developer by using something 
            ////called deterministic finilisation

            //Car myThirdCAr = new Car("Ford", "Escape", 2005, "White");//Overloaded constructor example

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Creating a constructor Car() and setting one of the properties of the Car class so as to fix it for
        //all instances created in this class.
        //For e.g. all objects in this class will now have a Model of Nissan as a fixed property
        public Car()
        {
           this.Make = "Nissan";
            // Note: this. is optional and cabe removed. It indicates that the property Make belongs to this class.
            //You coud load information in your instances from a configuration file, a database etc. 
        }

        //Create a n overloaded constructor for learning purpose
        //Example of instance method
        //to use these methods an instance has to be created
        public  Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }
        //Example of Static Keyword
        //Static methods and classes allow their properties to be used without the need of creating any INSTANCE
        public static void MyMethod()
        {
            Console.WriteLine("Called static MyMethod"); 
        }

    }
}
