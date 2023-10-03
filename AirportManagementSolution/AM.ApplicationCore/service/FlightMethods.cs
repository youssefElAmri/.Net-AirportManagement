using AM.ApplicationCore.publicinterface;
using AM.ApplicationCore.service;
using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.service
{
    public class FlightMethods:IFlightMethods
    {
        public List<Flight> Flights = new List<Flight>();
        public List<DateTime> GetFlightDates(String destination)
        {
            List <DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }

            }return dates;
        }

        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            // Validate filterType
            if (string.IsNullOrWhiteSpace(filterType))
                throw new ArgumentException("Filter type cannot be null or empty.", nameof(filterType));

            // Validate filterValue
            if (string.IsNullOrWhiteSpace(filterValue))
                throw new ArgumentException("Filter value cannot be null or empty.", nameof(filterValue));

            // Filter flights based on the specified filterType and filterValue
            List<Flight> filteredFlights = Flights.Where(flight => GetFilterValue(flight, filterType).Equals(filterValue, StringComparison.OrdinalIgnoreCase)).ToList();

            return filteredFlights;
        }

        // Helper method to get the filter value based on the filter type
        private string GetFilterValue(Flight flight, string filterType)
        {
            switch (filterType.ToLower())
            {
                case "destination":
                    return flight.Destination;
                case "departure":
                    return flight.Departure;
                // Add more cases for other filter types as needed
                default:
                    throw new ArgumentException("Invalid filter type.", nameof(filterType));
            }
        }

    }
}
