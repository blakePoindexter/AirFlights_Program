using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AirFlights
{
    internal class Flights
    {
        static void Main(string[] args)
        {
            int input;
            string output;
            int[] flightNumber = new int[] { 201, 321, 510, 633 };
            string[] airportCode = new string[] { "AUS", "CRP", "DFW", "HOU" };
            string[] airportName = new string[] { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
            int[] time = new int[] { 0710, 0830, 0915, 1140 };

            WriteLine("Enter the flight number or airport code >> ");
            output = GetFlightInfo(input, flightNumber[], airportCode, airportName, time);

        }
        public static string GetFlightInfo(string code, int[] flightNumbers,
        string[] codes, string[] names, string[] times)
        {
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(code))
                {
                    // return a string with all the flight details if
                    // the code is found
                    return "Flight #" + flightNumbers[i] + " " + codes[i]
                    + " " + names[i] + " Scheduled at: " + times[i];
                }
                else
                {
                    // return a message if the code is not found
                    return "Airport #" + code + " not found.";
                }
            }
            
        }
    }

        public static string GetFlightInfo(int flight, int[] flightNumbers,
        string[] codes, string[] names, string[] times)
        {
            for (int i = 0; i < flightNumbers.Length; ++i)
                if (flightNumbers[i] == flight)
                { return "Flight #" + flightNumbers[i] + " " + codes[i] + " " + names[i] +
                        "Scheduled for : " + times[i];
                }
                else
                {
                    return "Flight #" + flight + " not found.";
                }

        }
    }
}
