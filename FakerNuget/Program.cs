using System;
using System.Collections;
using System.Collections.Generic;
using Faker;

namespace FakerNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePerson();
            GeneratePerson();
            GeneratePerson();

            Console.WriteLine("Press any key to close this window...");
            Console.ReadLine();
        }

        static void GeneratePerson()
        {
            var firstName = Faker.Name.First();
            var lastName = Faker.Name.Last();
            var address = Faker.Address.StreetAddress();
            var city = Faker.Address.City();
            var number = Faker.RandomNumber.Next(100);
            var dob = Faker.Identification.DateOfBirth();

            var ssn = Faker.Identification.SocialSecurityNumber();
            var mbi = Faker.Identification.MedicareBeneficiaryIdentifier();
            var usPassport = Faker.Identification.UsPassportNumber();

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(address);
            Console.WriteLine(city);
            Console.WriteLine(number);
            Console.WriteLine(dob);
            Console.WriteLine(ssn);
            Console.WriteLine(mbi);
            Console.WriteLine(usPassport);
            Console.WriteLine("");
        }
    }
}
