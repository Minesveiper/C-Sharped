using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharped
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------Diamond------------------------------------------------
            /*
            Console.WriteLine("Display the pattern like diamond:");
            Console.WriteLine("----------------------------------\n");
            Console.Write("Input number of rows (All of the diamond): "); // I wrote it to account for all of the diamond.
            int diamondRows = int.Parse(Console.ReadLine());
            int k = diamondRows/2;
            Console.WriteLine("\n");

            for (int i = 1; i < k; i++)     //Increase Loop
            {
                for (int j = i; j < k; j++)
                {
                    Console.Write(" ");     // spaces
                }
                for (int h = 0; h < i*2-1; h++)
                {
                    Console.Write("*");     //stars
                }
                Console.WriteLine();
            }
            for (int i = k; i > 0; i--)     //Decrease Loop
            {
                for (int j = i; j < k; j++)
                {
                    Console.Write(" ");     // spaces
                }
                for (int h = 0; h < i * 2 - 1; h++)
                {
                    Console.Write("*");     //stars
                }
                Console.WriteLine();
            }
            */
            //----------------------------------------------------------------------------

            //----------------------------------------------------------------------------

            Car bmw = new Car("Red", "BMW", 5);

            //bmw.Drive();
            bmw.OpenWindow();
            bmw.OpenRadio();

            Ecar nissan = new Ecar("White", "Nissan ARIYA");

            //nissan.Drive();

            Motorcycle harley = new Motorcycle("Black", "Harley Davidson", 4);
            
            //harley.Drive();


            //-------------Substring------------------------------------------------------
            /*
            string strang = "Rock'n roll is good for your soul";
            bool subs = strang.Contains("roll is good");
            Console.WriteLine(subs);
            */
            //----------------------------------------------------------------------------

            //-------------Fibonacci Numbers----------------------------------------------
            //Fibonacci(8);
            //Fibonacci(15);
            //----------------------------------------------------------------------------

        }

        private static void Fibonacci(int number)
        {
            int a = 0; int b = 1; int c = 0;
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                Console.Write($"{c} " );
                a = b;
                b = c;

            }
            Console.WriteLine($" - End Calculation of Fibonacci numbers at {number}.");
        }
    }
}

