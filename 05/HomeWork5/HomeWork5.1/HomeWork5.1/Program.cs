using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose the type of shape : \n 1. Circle, \n 2. Triangle, \n 3. Rectangle ");
                var figure = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (figure)
                {
                    case 1:
                        Console.WriteLine("Enter the circle radius: ");
                        Console.WriteLine();
                        var radius = double.Parse(Console.ReadLine());
                        var areaCircle = Math.PI * Math.Pow(radius, 2);
                        var circumference = 2 * Math.PI * radius;
                        Console.WriteLine($" \n The area of a circle: {Math.Round(areaCircle,2)}, \n Circumference: {Math.Round(circumference, 2)}");

                        break;

                    case 2:
                        Console.WriteLine("Enter the length of the triangle side: ");
                        Console.WriteLine();
                        var length = double.Parse(Console.ReadLine());
                        var areaTriangle = (Math.Sqrt(3) / 4 * Math.Pow(length, 2));
                        var perimeterTriangle = 3 * length;
                        Console.WriteLine($" \n The area of a triangle: {Math.Round(areaTriangle, 2)}, \n The perimeter of the triangle: {Math.Round(perimeterTriangle, 2)}");

                        break;

                    case 3:
                        Console.WriteLine("Enter the height of the rectangle: ");
                        Console.WriteLine();
                        var height = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the width  of the rectangle: ");
                        Console.WriteLine();
                        var width = double.Parse(Console.ReadLine());
                        var areaRectangle = height * width;
                        var perimeterRectangle = 2 * height + 2 * width;
                        Console.WriteLine($" \n The area of a rectangle: {Math.Round(areaRectangle, 2)}, \n the perimeter of the rectangle: {Math.Round(perimeterRectangle, 2)}");
                        break;
                }

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value is Null!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input value format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too much importance!");
            }


        }
    }
}

