/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
{
        public class ComplexNumber
        {
            public int Real { get; set; }
            public int Imaginary { get; set; }

            
            public ComplexNumber(int real, int imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

           
            public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            
            public void Display()
            {
                Console.WriteLine($"{Real} + {Imaginary}i");
            }
        }
 
        class Lab8
        {
            static void Main(string[] args)
            {
                
                ComplexNumber complex1 = new ComplexNumber(3, 4); 
                ComplexNumber complex2 = new ComplexNumber(5, 6);  

                Console.WriteLine("First Complex Number:");
                complex1.Display();  

                Console.WriteLine("Second Complex Number:");
                complex2.Display();  

                
                ComplexNumber result = complex1 + complex2;

                Console.WriteLine("Sum of the Complex Numbers:");
                result.Display();  
            }
        }
    }*/
