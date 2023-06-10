using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the first line:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second line:");
            double p1 = Convert.ToDouble(Console.ReadLine());
            double q1 = Convert.ToDouble(Console.ReadLine());
            double p2 = Convert.ToDouble(Console.ReadLine());
            double q2 = Convert.ToDouble(Console.ReadLine());

            double length1 = CalculateLength(x1, y1, x2, y2);
            double length2 = CalculateLength(p1, q1, p2, q2);

            CompareLines(length1, length2);
        }

        static double CalculateLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }

        static void CompareLines(double length1, double length2)
        {
            if (length1 == length2)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("The first line is longer than the second line.");
            }
            else
            {
                Console.WriteLine("The second line is longer than the first line.");
            }
        }
    }
}