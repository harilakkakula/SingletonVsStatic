using System;

namespace SingletonVsStatic
{
    class Program
    {
        static void Main(string[] args)
        {

            double celcius = 37;double fahernheit = 98.6;
            Console.WriteLine($"Value of {celcius} celcius to fahernheit is {Convertor.ToFahrenheit(celcius)}");
            Console.WriteLine($"Value of {fahernheit} fahrenheit to celcius is {Convertor.ToCelcius(fahernheit)}");

            Console.ReadLine();
            

            ///IMP ************************************************
            /// When to use Single ton?
            /// In Real Time application we are useing in below seanarios
            /// Logging
            /// Managing a Connection or a pool of the connections to DataBase
            /// Print spooling
            /// File
            /// COnfiguration
            /// Cache
            /// Session based Shopping Cart

        }
    }
}
