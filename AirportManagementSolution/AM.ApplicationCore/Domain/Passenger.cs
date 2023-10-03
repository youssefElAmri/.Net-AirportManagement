using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger.");
        }


        public bool CheckProfile(string lastName, string firstName)
        {
            // Implementation for checking profile based on last name and first name
            // Return true or false based on the check
            // Example: return lastName == "Smith" && firstName == "John";
            return true;
        }
        public bool CheckProfile(string lastName, string firstName, string email)
        {
            // Implementation for checking profile based on last name, first name, and email
            // Return true or false based on the check
            // Example: return lastName == "Smith" && firstName == "John" && email == "john.smith@example.com";
            return true;
        }

        public override string ToString()
        {
            return $"Passenger ID: {Id}, Name: {FirstName} {LastName}, Passport: {PassportNumber}, Birth Date: {BirthDate}, Tel: {TelNumber}, Email: {EmailAddress}";
        }
    }
}
