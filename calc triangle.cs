using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding the triangle area = SQRT(s(s-a) (s-b) (s-c)) where s = (a + b + c)/2 and c is the base of the triangle
            //I am also going to find the perimeter and height of the triangle
            Console.WriteLine("To find the area, height and perimiter of the triangle please enter the values of each line where 'c' is the base of the triangle");

            double s, area;
            double a, b, c;
            double bH;
            double perim;
            double theta;

            //User input for lines A, B and C
            Console.WriteLine("Please enter the value of line a(adjacent): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of line b(hypotenuse): ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of line c(opposite): ");
            c = Convert.ToDouble(Console.ReadLine());

            //Using Herons formula to work our the area
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Find the base height of the triangle
            bH = area * (2 / c);

            //Finding the perimeter of the triangle
            perim = (a + b + c);

            //what type of triangle is it?
            theta = Math.Atan(c / a) * (180 / Math.PI);
            theta = Math.Acos(a / b) * (180 / Math.PI);
            theta = Math.Asin(c / b) * (180 / Math.PI);

            if (a == b && b == c)
                Console.Write("This is an equilateral triangle\n");
            else if (a == b || a == c || b == c)
                Console.Write("This is an isosceles triangle\n");
            else if (a != b && b != c && c != a)
                Console.Write("This is a scalene triangle\n");
            else _ = (theta == 90);
            Console.Write("This is a right angle triangle\n");

            //Printing the area, base height and perimeter of the triangle
            Console.WriteLine("The area of the triangle is: {0}", area);
            Console.WriteLine("The base height of the triangle is: {0}", bH);
            Console.WriteLine("The perimeter of the triangle is: {0}", perim);
        }
    }
}
