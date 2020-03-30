using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class SecondTask
    {
        public static int Show(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int Show(string a, int b)
        {
            int sum = Convert.ToInt32(a) + b;
            return sum;
        }

        public static string Greeting(string name, int age, string city)
        {
            string @string = "I have a girlfriend, her name is "+name+" she is "+age+" and she lives in "+city;
            return @string;
        }

        public static string Greeting(string name, string car)
        {
            string @string = "I have a girlfriend, her name is " + name + " she has a car " + car;
            return @string;
        }
        
        public static double CalcAreaSquare(double side)
        {
            Console.Write("Area of Square : ");
            return Math.Pow(side, 2);
        }
        
        public static int CalcAreaSquare(int side)
        {
            Console.Write("Area of Square : ");
            return Convert.ToInt32(Math.Pow(side, 2));
        }
    
        public static double CalcAreaTriangle(int side, int height)
        {
            Console.Write("Area of Triangle : ");
            return Convert.ToDouble(0.5 * side * height);
        }

        public static double CalcAreaTriangle(double side, double height)
        {
            Console.Write("Area of Triangle : ");
            return Convert.ToDouble(0.5 * side * height);
        }
        
        public static double CalcAreaTriangle(int side, double height)
        {
            Console.Write("Area of Triangle : ");
            return Convert.ToDouble(0.5 * side * height);
        }

        public static double CalcAreaTriangle(double side, int height)
        {
            Console.Write("Area of Triangle : ");
            return Convert.ToDouble(0.5 * side * height);
        }


        public static double CalcAreaTrapeze(int sideOne, int sideTwo, int height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(double sideOne, double sideTwo, double height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(double sideOne, int sideTwo, int height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(int sideOne, double sideTwo, int height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(int sideOne, int sideTwo, double height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(double sideOne, double sideTwo, int height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(int sideOne, double sideTwo, double height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }

        public static double CalcAreaTrapeze(double sideOne, int sideTwo, double height)
        {
            Console.Write("Area of Trapeze : ");
            return Convert.ToDouble((sideOne + sideTwo) * height);
        }
    }

}
