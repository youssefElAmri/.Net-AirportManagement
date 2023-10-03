using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        // Properties representing plane attributes
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        // Navigation property to represent the relationship with Flight
        public ICollection<Flight> Flights { get; set; }

        // Constructor to initialize properties
        public Plane()
        {
            Flights = new List<Flight>();
            // Initialize DateTime property with a default value
            ManufactureDate = DateTime.Now;
        }

        // Constructor with specified parameters
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }

        // Method to override ToString() for meaningful representation
        public override string ToString()
        {
            return $"Plane ID: {PlaneId}, Capacity: {Capacity}, Manufacture Date: {ManufactureDate}, Plane Type: {PlaneType}";
        }
    }
}
