using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Students
{
    internal class Student
    {
        static int counter = 0;
        public Student()
        {
            this.Id = ++counter;
        }
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            Console.WriteLine("=====STUDENT INFO=====");
            return $"ID:{Id},Name:{Name},Surname:{Surname},Date of birth:{DateOfBirth}";
        }

    }
}
