using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Grunderna_OOP
{
    public class Circle
    {
        // Anväds för se antal objekt
        static int objectCounter = 0;

        public int id { get; set; }
        public double diameter { get; set; }
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.diameter = radius * 2;
            this.radius = radius;
            this.id = ++objectCounter;
        }

        // Formel arean = r^2 * Pi.
        public double getArea(double radius)
        {
            double area = Math.Pow(radius, 2) * Math.PI;

            return area;
        }

        // Formel för omkrets = D * Pi
        public double getCircumference(double diameter)
        {
            
            double circumference = diameter * Math.PI;

            return circumference;
        }

        //Formel för volym = (4 * Pi * 3^3) /3
        public double getVolym (double radius)
        {
            double volym = (4 * Math.PI * Math.Pow(radius, 3) / 3);

            return volym;
        }

        public void infoCircle()
        {
            // Inom metoden så kommer den genomföra alla uträkningen för cirkel 
            double circumference = getCircumference(diameter);
            double area = getArea(radius);
            double volym = getVolym(radius);
            
            Console.WriteLine($"Din cirkel: Nr{id}");
            Console.WriteLine($"Diameter: {diameter}");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Arean: {area}");
            Console.WriteLine($"Omkrets: {circumference} ");
            Console.WriteLine($"Volym: {volym}");
        }
    }
}
