using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharped
{
    internal class Vehicle
    {

        public Vehicle(string colour, string manufacturer, int gasLevel)
        {
            //
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

    internal class Car : Vehicle
    {
        public void OpenWindow()
        {
            Console.WriteLine("Car window is open,...\nAhh, fresh air!");
        }

        public void OpenRadio()
        {
            Console.WriteLine("Open car radio,...\nJeee, rock'n roll!");
        }
    }

    internal class Ecar : Vehicle 
    {
        //Override Drive()
    }

    internal class Motorcycle : Vehicle
    {
        public void PutHelmetOn()
        {
            Console.WriteLine("Helmet suits well,...\nNice and safe!");
        }
    }
}
