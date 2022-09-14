﻿using System;
using System.Collections.Generic;
using System.Linq;
using Сортировка_критических_пациентов;

namespace Задача_2
{
    internal class Program
    {
        private static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            var patients = new List<Patient>
            {
                new Patient ("Alex", "Mitchel", 21, "critical"),
                new Patient ("Kate", "Pupsvel", 18, "critical"),
                new Patient ("Georgy", "Robbinson", 42, "normal"),
                new Patient ("LG", "Company", 120, "normal"),
                new Patient ("Mikky", "Mouse", 30, "critical")
            };

            Methods.LessThan(patients);

            Console.WriteLine();

            Methods.FindByName(patients);

            Console.WriteLine();

            Methods.FindBySurname(patients);

            Console.WriteLine();

            Methods.CriticalPatients(patients);

            Console.ReadLine();
        }
    }
}