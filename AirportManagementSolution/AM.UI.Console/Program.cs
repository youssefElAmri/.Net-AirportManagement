using System;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.service;

namespace AM.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightMethods flightMethods = new FlightMethods();

            // Assuming you have flights in the Flights list, you can add them here
            // For demonstration purposes, let's assume we have some flights already added
            flightMethods.Flights.Add(new Flight { FlightId = 1, Destination = "Paris" });
            flightMethods.Flights.Add(new Flight { FlightId = 2, Destination = "London" });

            // Call GetFlights with a filter
            List<Flight> filteredFlights = flightMethods.GetFlights("Destination", "Paris");

            // Display the filtered flights
            foreach (var flight in filteredFlights)
            {
                System.Console.WriteLine($"Flight ID: {flight.FlightId}, Destination: {flight.Destination}");
            }
        }
    }
}
