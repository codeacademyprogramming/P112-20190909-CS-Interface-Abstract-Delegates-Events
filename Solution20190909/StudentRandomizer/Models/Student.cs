using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRandomizer.Models
{
    sealed class Student : Person
    {



        public string Email { get; set; }
        public string GroupName { get; set; }

        public Student(string name, string surname, int age)
        {
            Surname = surname;
            Age = age;
        }

        public override string GetInfo()
        {
            return $"{Name}";
        }
    }
}
