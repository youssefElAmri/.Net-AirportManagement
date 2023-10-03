using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

        // Navigation property to represent the relationship with Plane
        public Plane Plane { get; set; }
        public Flight()
        {
            // Initialize DateTime properties with a default value
            FlightDate = DateTime.Now;
            EffectiveArrival = DateTime.Now;
        }

        // Method to override ToString() for meaningful representation
        public override string ToString()
        {
            return $"Flight ID: {FlightId}, Date: {FlightDate}, Duration: {EstimatedDuration} minutes, Arrival: {EffectiveArrival}, Departure: {Departure}, Destination: {Destination}";
        }
    }
}
