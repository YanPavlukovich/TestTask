using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Задача_2
{
    internal class Methods
    {
        public static void LessThan(List<Patient> patients)
        {
            try
            {
                Console.WriteLine("Enter age to sort in descending order from this number");
                int number = Int32.Parse(Console.ReadLine());

                var lessThen = from people in patients
                               where people.age < number
                               select people;
                foreach (var person in lessThen)
                {
                    Console.WriteLine($"{person.Name} {person.Surname}");
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error. You must enter a number.");
                Console.ResetColor();
                Console.WriteLine();
                LessThan(patients);
            }
        }

        public static void FindByName(List<Patient> patients)
        {
            Console.WriteLine("Enter the name of patient for search in list");
            string name = Console.ReadLine();

            bool hasName = patients.Any(people => people.Name == name);

            if (hasName == true)
            {
                var correctName = from people in patients
                                  where people.Name == name
                                  select people;
                foreach (var person in correctName)
                {
                    Console.WriteLine($"{person.Name} {person.Surname}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error. Name not found.");
                Console.ResetColor();
                Console.WriteLine();
                FindByName(patients);
            }
        }

        public static void FindBySurname(List<Patient> patients)
        {
            Console.WriteLine("Enter the surname of patient for search in list");
            string surname = Console.ReadLine();

            bool hasSurname = patients.Any(people => people.Surname == surname);

            if (hasSurname == true)
            {
                var correctSurname = from people in patients
                                     where people.Surname == surname
                                     select people;
                foreach (var person in correctSurname)
                {
                    Console.WriteLine($"{person.Name} {person.Surname}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error. Surname not found.");
                Console.ResetColor();
                Console.WriteLine();
                FindBySurname(patients);
            }
        }

        public static void CriticalPatients(List<Patient> patients)
        {
            Console.WriteLine("Below are critically ill patients");
            var criticalPatients = from people in patients
                                   where people.status == "critical"
                                   select people;
            foreach (var person in criticalPatients)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{person.Name} {person.Surname}");
                Console.ResetColor();
            }
        }
    }
}