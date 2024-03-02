using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;

            float num1;
            float num2;
            float result;

            string answer;
            Console.WriteLine("welcome to the Console Calculator App!!");
            Console.WriteLine("Pls enter your first Number!");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine( "Pls Enter your second Number!!");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Select your Operator");
            Console.WriteLine("a for Addition, s for subtraction, m for multiplication, then any other key for division");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
;            }
            else
            {
                result = num2 == 0 ? num1 : num1 / num2;
            }
            if(num2 == 0)
            {
                Console.WriteLine(  "cannot be divided by 0");
            }
            else
            {
                Console.WriteLine(  "your result is {0}", result);
            }
            Console.WriteLine("Thank toy for trying out this App!!");
            Console.ReadKey();
        }
    }
}