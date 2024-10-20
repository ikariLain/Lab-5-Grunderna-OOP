using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cirkel 1 Radie = 5
            Circle cirkel1 = new Circle(5);

            // Visar info över cirkel 1
            cirkel1.infoCircle();

            //Skapar object cirkel 2 med radie 2
            Circle cirkel2 = new Circle(6);

            // Visar info över cirkel 2 
            cirkel2.infoCircle();

            Console.WriteLine();

            // Skapar en objekt med triangel 1 
            Triangle triangle1 = new Triangle(5,10,8,6,7);

            triangle1.infoTriangle();

        }
    }
}
