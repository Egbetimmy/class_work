using System;

namespace Wema.BIT.User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            double x1;
            double x2;
            double x;
            double r;

            Console.WriteLine("Input the value of a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the value of b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the value of c");
            c = Convert.ToDouble(Console.ReadLine());

            r = (Math.Pow(b, 2) - (4 * a*c));

            if (r < 0)
            {
                x = (Math.Sqrt(Math.Abs(Math.Pow(b, 2) - (4 * a * c))));
                Console.WriteLine("No real roots ");
                Console.WriteLine($"x1 =  {-b/(2*a)} + {x/(2*a)}i ");
                Console.WriteLine($"x1 =  {-b / (2 * a)} - {x / (2 * a)}i ");
            }
            else if(r == 0)
            {
                x1 = (-b + r) / (2 * a);
                Console.WriteLine($"roots is repeated x1 and x2 =  {x1}");
            }
            else
            {
                x1 = (-b + r) / (2 * a);
                x2 = (-b - r) / (2 * a);
                Console.WriteLine("Root1: " + x1 + ", Root2: " + x2);
            }
        }
    }
}

