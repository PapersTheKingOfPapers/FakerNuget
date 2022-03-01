using System;
using System.Collections;
using System.Collections.Generic;
using Faker;
using CommandLine;

namespace FakerNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLine>(args).WithParsed<CommandLine>(o =>
            {
                if (o.Interactive)
                {
                    Console.WriteLine("How many fake people would you like to print?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < amount; i++)
                    {
                        GeneratePerson();
                    }
                }
                else if(!string.IsNullOrEmpty(o.personCount))
                {
                    int x = Convert.ToInt32(o.personCount);
                    for (int i = 0; i < x; i++)
                    {
                        GeneratePerson();
                    }
                }
            });

            Console.WriteLine("Press enter to close this window...");
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
