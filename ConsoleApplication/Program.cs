using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Matthew LeFevre";
            string location = "Idaho";

            Console.WriteLine($"My name is  {name}");
            Console.WriteLine($"and I live in { location}");

            var today = DateTime.Today;

            Console.WriteLine(today.ToString());

            string daysLeft = "245";
            Console.WriteLine($"There are {daysLeft} days left till christmas.");
        }
    }
}
