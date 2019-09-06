using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double circleArea;

            //Ask the user for the Radius of the circle
            Console.Write("Please enter the radius of the circle: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            //Calculate the area of the circle according to the formula
            circleArea = 3.14 * radius * radius;

            //Outputing the result of the formula
            Console.WriteLine("\nThe Radius you entered is: " + radius);
            Console.WriteLine("\nThe Calculation for the area of the circle is: " + circleArea);


            //Another way to output the result
            Console.WriteLine("\n\nThe radius enterd is: " + radius + " so the Area is: " + circleArea + "\n");

        }
    }
}
