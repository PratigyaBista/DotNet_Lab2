/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
{
    class Person
    {
    
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; }

        private string password;
        public string Password
        {
            set { password = value; }
        }

        public string Gender { get; set; }
        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.Age = age;
            this.Gender = gender;
        }
 
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            Person person = new Person("Pratigya", 20, "Female");

            
            Console.WriteLine("Read-Write Property (Name): " + person.Name);

            
            person.Name = "Pratigya Bista";
            Console.WriteLine("Modified Name: " + person.Name);

            
            Console.WriteLine("Read-Only Property (Age): " + person.Age);

            
            person.Password = "mySecurePassword";
            Console.WriteLine("Password is set.");

            
            Console.WriteLine("Auto-Implemented Property (Gender): " + person.Gender);

           
            person.DisplayInfo();
        }
    }
}*/
