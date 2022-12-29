using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using Area;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            while (type != "triangle" && type != "circle")
            {
                Console.WriteLine("Input figure type: (triangle, circle)");
                type = Console.ReadLine();
            }
            switch (type.ToLower())
            {
                case "triangle":
                    {
                        double a, b, c = 0;
                        do
                        {
                            Console.WriteLine("Input sides of the triangle: ");
                            a = double.Parse(Console.ReadLine());
                            b = double.Parse(Console.ReadLine());
                            c = double.Parse(Console.ReadLine());
                            if ((a + b < c) || (b + c < a) || (c + a < b)|| (a<=0) || (b <= 0) || (c <= 0))
                            {
                                Console.WriteLine("Incorrect values of sides");
                            }
                        }
                        while ((a + b <= c) || (b + c <= a) || (c + a <= b));
                        Console.WriteLine("S = " + CalcArea.Triangle(a, b, c));
                    }
                    break;
                case "circle":
                    {
                        Console.WriteLine("Input radius of the circle: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("S = " + CalcArea.Circle(a));
                    }
                    break;
                default: Console.WriteLine("Incorrect figure type");
                    break;
            };
        }
    }
}
