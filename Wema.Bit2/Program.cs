using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.Bit2
{
    public class User
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Hello world!");
            Payment.Greet();
            Payment p = new Payment();
            p.GreetMe();

            string greet = p.GreetMe();

            Console.WriteLine(greet);
        }


    }
    public class Payment
    {
        public static void Greet()
        {
            Console.WriteLine("Good Afternoon");
        }

        public string GreetMe()
        {
            Console.WriteLine("Good Afternoon");

            return "Good Afternoon";
        }
    }


}
