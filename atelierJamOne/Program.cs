using System;

namespace atelierJamOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! Please choose any of these operators for calculation!");
            
            // Only if I could ask for the input here but the jam rules ¯\_(ツ)_/¯
            // Moral of the story- The code is this long just because its the requirment
            // I am not really this terrible at programming (although I did have to ask for help)

            while (true)
            {   
                Console.WriteLine("\n+ for addition \n- for subtraction \n* for multiplication\n/ for division");
                Console.WriteLine("Input: ");

                switch (Console.ReadLine())
            {
                case "+": // addition stuff
                
                Console.WriteLine("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int num3 = num1 + num2;

                Console.WriteLine($"{num1} + {num2} = {num3} " );
                break;

                case "-": // subtraction stuff

                Console.WriteLine("Please enter a number");
                int num4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int num5 = Convert.ToInt32(Console.ReadLine());

                int num6 = num4 - num5;

                Console.WriteLine($"{num4} - {num5} = {num6} " );
                break;

                case "*": // multiplication stuff

                Console.WriteLine("Please enter a number");
                int num7 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int num8 = Convert.ToInt32(Console.ReadLine());

                int num9 = num7 * num8;

                Console.WriteLine($"{num7} * {num8} = {num9} " );
                break;

                case "/": // division stuff

                Console.WriteLine("Please enter a number");
                int num0 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int num01 = Convert.ToInt32(Console.ReadLine());

                int num02 = num0 / num01;

                Console.WriteLine($"{num0} / {num01} = {num02} " );
                break;

            }
            Console.WriteLine("If you want to continue, press any key. \nTo exit the program, press e");

            if (Console.ReadLine() == "e")
            {
                return;
            }
            
            }
        }
    }
}
