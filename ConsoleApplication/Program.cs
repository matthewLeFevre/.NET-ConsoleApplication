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

            Console.WriteLine(today.ToString("d"));

            DateTime christmas = new DateTime(today.Year, 12, 25);

            string daysLeft = (christmas - today).TotalDays.ToString();
            Console.WriteLine($"There are {daysLeft} days left till christmas.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("what is the area of the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
             
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
