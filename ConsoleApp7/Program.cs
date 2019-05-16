using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            person.name = "John";
            person.surname = "Kowalski";
            person.age = 25;

            Console.WriteLine(person.name);
            Console.WriteLine(person.surname);
            Console.WriteLine(person.age);

            Console.ReadKey();
        }
            class Human
        {
            public string name,surname;
            public int age;
        }
    }
}
