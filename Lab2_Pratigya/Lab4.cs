/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
    {
       
        public class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }

        // Single Inheritance
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking.");
            }
        }

        // Hierarchical Inheritance
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"{Name} is meowing.");
            }
        }

        // Multilevel Inheritance
        public class GermanShepherd : Dog
        {
            public void Guard()
            {
                Console.WriteLine($"{Name} is guarding the house.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Single Inheritance
                Dog dog = new Dog { Name = "Sallu" };
                dog.Eat();  
                dog.Bark();

                // Hierarchical Inheritance
                Cat cat = new Cat { Name = "Mayalu" };
                cat.Eat();  
                cat.Meow();

                // Multilevel Inheritance
                GermanShepherd germanShepherd = new GermanShepherd { Name = "Max" };
                germanShepherd.Eat();  
                germanShepherd.Bark(); 
                germanShepherd.Guard(); 
            }
        }
    }*/

   