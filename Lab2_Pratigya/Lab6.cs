/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
{
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // Default constructor
            public Person()
            {
                Name = "Unknown";
                Age = 0;
                Console.WriteLine("Default constructor called.");
            }

            // Parameterized constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Parameterized constructor called.");
            }

            // Copy constructor
            public Person(Person other)
            {
                Name = other.Name;
                Age = other.Age;
                Console.WriteLine("Copy constructor called.");
            }

            // Static constructor
            static Person()
            {
                Console.WriteLine("Static constructor called once per class.");
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        class Lab6
        {
            static void Main(string[] args)
            {
                
                Console.WriteLine("Example using default constructor:");
                Person person1 = new Person();  // Default constructor
                person1.DisplayInfo();

                Console.WriteLine("\nExample using parameterized constructor:");
                Person person2 = new Person("Pratigya", 21);  // Parameterized constructor
                person2.DisplayInfo();

                Console.WriteLine("\n Example using copy constructor:");
                Person person3 = new Person(person2);  // Copy constructor
                person3.DisplayInfo();
            }
        }
    }*/

   