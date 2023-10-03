using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }
        public string Function { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();  // Call the base class implementation
            Console.WriteLine("I am a Staff Member.");
        }

        public override string ToString()
        {
            return $"Staff ID: {Id}, Name: {FirstName} {LastName}, Passport: {PassportNumber}, Birth Date: {BirthDate}, Tel: {TelNumber}, Email: {EmailAddress}, Employment Date: {EmploymentDate}, Salary: {Salary}, Function: {Function}";
        }
    }
}
