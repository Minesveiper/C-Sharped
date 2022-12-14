using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharped
{
    internal class Vehicle
    {
        public string Colour { get; set; }  //colour
        public string Manufacturer { get; set; }    //manufacturer
        public string GasLevel { get; set; }    //gas level

        //Drive()
    }

    internal class Car : Vehicle
    {
        //OpenWindow()
        //OpenRadio()
    }

    internal class Ecar : Vehicle 
    {
        //Override Drive()
    }

    internal class Motorcycle : Vehicle
    {
        //PutHelmetOn()
    }
}
