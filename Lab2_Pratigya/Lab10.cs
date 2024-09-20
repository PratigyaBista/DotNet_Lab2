/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Pratigya
{
    public class Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

       
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    
    public class Rectangle : Shape
    {
        
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

       
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Lab10
    {
        static void Main(string[] args)
        {
            
            Rectangle rect = new Rectangle(10, 10);

            
            Console.WriteLine("The area of the rectangle is: " + rect.CalculateArea());
        }
    }
}*/
