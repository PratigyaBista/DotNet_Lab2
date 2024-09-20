using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
{
    public class GenericClass<T>
    {
        
        private T data;

       
        public GenericClass(T value)
        {
            data = value;
        }

        
        public T GetData()
        {
            return data;
        }

        // A generic method to display data
        public void DisplayData()
        {
            Console.WriteLine("Data: " + data);
        }

       
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }

    class Lab11
    {
        static void Main(string[] args)
        {
           
            GenericClass<int> intInstance = new GenericClass<int>(10);
            intInstance.DisplayData();
            Console.WriteLine("Sum of 10 and 20: " + intInstance.Add(10, 20));

           
            GenericClass<string> stringInstance = new GenericClass<string>("Hello");
            stringInstance.DisplayData();
            
            Console.WriteLine("Concatenation of 'Hello' and ' World': " + stringInstance.Add("Hello", " World"));

            
            GenericClass<double> doubleInstance = new GenericClass<double>(5.5);
            doubleInstance.DisplayData();
            Console.WriteLine("Sum of 5.5 and 4.5: " + doubleInstance.Add(5.5, 4.5));
        }
    }
}
