using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
     public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();  // Call the base class implementation
            Console.WriteLine("I am a Traveller.");
        }
        public override string ToString()
        {
            return $"Traveller ID: {Id}, Name: {FirstName} {LastName}, Passport: {PassportNumber}, Birth Date: {BirthDate}, Tel: {TelNumber}, Email: {EmailAddress}, Health Information: {HealthInformation}, Nationality: {Nationality}";
        }
    }

    
}
