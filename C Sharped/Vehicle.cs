using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharped
{
    public class Vehicle
    {
        public string colour;
        public string manufacturer;
        public string gasLevel;

        public Vehicle(string colour, string manufacturer, int gasLevel)
        {
        

        }
        //public string Colour { get; set; }  //colour
        //public string Manufacturer { get; set; }    //manufacturer
        //public string GasLevel { get; set; }    //gas level

        public void Drive()
        {
            //Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }

    public class Car : Vehicle
    {
        public Car(string colour, string manufacturer, int gasLevel) : base(colour, manufacturer, gasLevel)
        {
        }

        public void OpenWindow()
        {
            Console.WriteLine("Car window is open,...\nAhh, fresh air!");
        }

        public void OpenRadio()
        {
            Console.WriteLine("Open car radio,...\nJeee, rock'n roll!");
        }
    }

    public class Ecar : Vehicle
    {
        //Override Drive()
        public Ecar(string colour, string manufacturer, int gasLevel) : base(colour, manufacturer, gasLevel)
        {
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string colour, string manufacturer, int gasLevel) : base(colour, manufacturer, gasLevel)
        {
        }

        public void PutHelmetOn()
        {
            Console.WriteLine("Helmet suits well,...\nNice and safe!");
        }
    }
}
