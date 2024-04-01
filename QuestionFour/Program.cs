using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //#4 Write a Promgram to print area of circle, rectangle & square.
            //Formulas:->
            //1. Area of cycle = π×radius^2
            //2. Area of Rectangle = longest_side × shortest_side
            //3. Area of Square = side^2


            Console.WriteLine("#4 Write a Promgram to print area of circle, rectangle & square.");
            Console.WriteLine("================================================================");
            Console.WriteLine("User input:->");
            Console.WriteLine("+++++++++++++");

            double radius = 0, longest_side = 0, shortest_side = 0, area_cycle = 0, area_reatangle = 0, area_square = 0;
            Console.WriteLine("Enter the Radius:->");
            double.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine("Enter the Longest Side:->");
            double.TryParse(Console.ReadLine(), out longest_side);
            Console.WriteLine("Enter the shortest Side:->");
            double.TryParse(Console.ReadLine(), out shortest_side);

            area_cycle = Math.PI * Math.Pow(radius, 2);
            area_reatangle = longest_side * shortest_side;
            area_square = Math.Pow(longest_side,2);
            //area_square = Math.Pow(shortest_side, 2);

            Console.WriteLine("Result:->");
            Console.WriteLine("*********");
            Console.WriteLine("Area of Cycle of radius {0} is {1}\nThe Area of rectangle of longest side {2} & shortest side {3} is {4}\nAnd the area of square of side {5} is {6}", radius, area_cycle,longest_side,shortest_side, area_reatangle,longest_side,area_square);
            Console.ReadKey();
        }
    }
}
