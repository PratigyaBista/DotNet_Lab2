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

           
            public virtual void Sound()
            {
                Console.WriteLine($"{Name} makes a sound.");
            }
        }

       
        public class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine($"{Name} barks.");
            }
        }

       
        public class Cat : Animal
        {
            public override void Sound()
            {
                Console.WriteLine($"{Name} meows.");
            }
        }

        class Lab5
        {
            static void Main(string[] args)
            {
                Animal genericAnimal = new Animal { Name = "Generic Animal" };
                genericAnimal.Sound();  
                Dog dog = new Dog { Name = "Sallu" };
                dog.Sound();  
                Cat cat = new Cat { Name = "Khairi" };
                cat.Sound();  
            }
        }
    }*/