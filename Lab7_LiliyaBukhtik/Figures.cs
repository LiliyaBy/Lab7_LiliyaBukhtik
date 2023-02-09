using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_LiliyaBukhtik
{
    abstract class Figures
    {
        abstract public double CalculateArea();
        abstract public double CalculatePerimeter();

    }
   

    class Triangle : Figures
    {
        double sideA=5;
        double sideB=6;
        double sideC=7;
        public override double CalculateArea()
        {
            return  (sideA * sideB * Math.Sin(sideC)/2);
        }

        public override double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
            
        }
    }

    class Rectangle : Figures
    {
        double sideA=5;
        double sideB=7;
        double sideC=5;
        double sideD=7;
        public override double CalculateArea()
        {
            return sideA * sideB;
        }

        public override double CalculatePerimeter()
        {

            return sideA + sideB + sideC+ sideD; 
        }
    }
    class Circle : Figures
    {
        double radius=6;
        
        public override double CalculateArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        
    }

    
   
}
