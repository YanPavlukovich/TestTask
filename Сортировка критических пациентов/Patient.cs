using System;
using System.Collections.Generic;
using System.Text;

namespace Задача_2
{
    class Patient
    {
        public String Name;
        public String Surname;
        public int age;
        public String status;

        public Patient(string Name, string Surname, int age, string status)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.age = age;
            this.status = status;
        }
    }
}
