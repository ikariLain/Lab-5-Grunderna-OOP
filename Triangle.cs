using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Grunderna_OOP
{
    internal class Triangle
    {
        //Används för se antalet objekt 
        static int objectCounter = 0;

        public int id { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public double sida1 { get; set; }
        public double sida2 { get; set; }
        public double sida3 { get; set; }

        public Triangle(double height, double width, double sida1, double sida2 , double sida3)
        {
            this.id = ++objectCounter;
            this.height = height;
            this.width = width;
            this.sida1 = sida1;
            this.sida2 = sida2;
            this.sida3 = sida3;
        }

        //Formel för arean = (höjden * breden) / 2
        public double getArea(double height, double width)
        {
            double area = height * width / 2;

            return area;
        }
        // Formel för omkretsen = sida 1 + sida 2 + sida 3
        public double getPerimeter(double sida1, double sida2, double sida3)
        {
            double perimeter = sida1 + sida2 + sida3;

            return perimeter;
        }

        //Formel för volymen av en prisma = arean * höjden  
        public double getVolym (double area, double height)
        {
            double volym = area * height;

            return volym;
        }

        
        public void infoTriangle()
        {
            // Inom metoden så kommer den genomföra alla uträkningen för triangel 
            double area = getArea(height,width);
            double perimeter = getPerimeter(sida1, sida2, sida3 );
            double volym = getVolym(area, height);

            Console.WriteLine($"Din triangel: Nr {id}");
            Console.WriteLine($"Höjd: {height}");
            Console.WriteLine($"Bredd: {width}");
            Console.WriteLine($"Sida 1: {sida1}");
            Console.WriteLine($"Sida 2: {sida2}");
            Console.WriteLine($"Sida 3: {sida3}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Arean: {area}");
            Console.WriteLine($"Omkrets: {perimeter}");
            Console.WriteLine($"Volym: {volym}");
            Console.WriteLine("-------------------");
        }
    }
}
