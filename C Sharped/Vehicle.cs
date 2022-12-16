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
        public int gasLevel;
        
        public Vehicle(string colour, string manufacturer, int gasLevel) // Constructor
        {
            this.colour = colour;
            this.manufacturer = manufacturer;
            this.gasLevel = gasLevel; //Bakerste e constructorvaluen. Første e den globale valuen

        }
        public Vehicle(string colour, string manufacturer) // Constructor
        {
            this.colour = colour;
            this.manufacturer = manufacturer;
            //Bakerste e constructorvaluen. Første e den globale valuen

        }
        /*
        public string Colour { get; set; }  //colour
        public string Manufacturer { get; set; }    //manufacturer
        public string GasLevel { get; set; }    //gas level
        */
        public virtual void Drive()
        {
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine($"{colour} {manufacturer}");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("Motor is running, VROOOOOM");
            Console.ForegroundColor= ConsoleColor.White;

            do
            {
                gasLevel--;
                Console.WriteLine($"Gas level: {gasLevel}");
                Console.WriteLine("Continue driving? Yes (y) No (Enter)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n");
                    continue;
                }
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    return;
                }


            }
            while (gasLevel > 1);
                Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\n\nRun out of gas!");
            Console.ForegroundColor= ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Car window is open,...\nAhh, fresh air!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OpenRadio()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Open car radio,...\nJeee, rock'n roll!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class Ecar : Vehicle
    {
        public override void Drive() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{colour} {manufacturer}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Motor is running, ssshhhhhhh!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Ecar(string colour, string manufacturer) : base(colour, manufacturer)
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Helmet suits well,...\nNice and safe!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
