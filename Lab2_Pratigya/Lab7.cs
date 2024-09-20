/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
    {
        public class Counter
        {
            public int Value { get; set; }

            
            public Counter(int initialValue)
            {
                Value = initialValue;
            }

            
            public static Counter operator ++(Counter c)
            {
                
                c.Value += 1;
                return c;
            }

            
            public void Display()
            {
                Console.WriteLine($"Counter Value: {Value}");
            }
        }

        class Lab7
        {
            static void Main(string[] args)
            {
               
                Counter count = new Counter(5);

                Console.WriteLine("Before incrementing:");
                count.Display();  
                
                ++count;

                Console.WriteLine("After incrementing:");
                count.Display();  
            }
        }
    }*/
