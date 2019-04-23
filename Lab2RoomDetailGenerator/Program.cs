using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2RoomDetailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;
            string response = "y";

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! ");

            while (response == "y")
            {
                Console.Write("Please enter the length of your room ");
                while (!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.Write("Invalid Entry:  Please enter a numerical value.  Please enter the length of your room ");
                }

                Console.Write("Please enter the width of your room ");
                while (!double.TryParse(Console.ReadLine(), out width))
                {
                    Console.Write("Invalid Entry:  Please enter a numerical value.  Please enter the width of your room ");
                }

                Console.Write("Please enter the height of your room ");
                while (!double.TryParse(Console.ReadLine(), out height))
                {
                    Console.Write("Invalid Entry:  Please enter a numerical value.  Please enter the height of your room ");
                }

                area = length * width;
                Console.WriteLine("The area of your room is " + area);
                perimeter = 2 * (length + width);
                Console.WriteLine("The perimeter of your room is " + perimeter);
                volume = length * height * width;
                Console.WriteLine("The volume of your room is " + volume);
                Console.WriteLine("Type y to continue or n to exit: ");
                response = Console.ReadLine();

            }  
        }
    }
}
