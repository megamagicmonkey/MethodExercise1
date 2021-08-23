using System;

namespace MethodsExercise1
{
    class Program
    {
        public static string answer1;
        public static string answer2;
        public static string answer3;
        public static string answer4;
        static void Main(string[] args)
        {
            int x = 0;
            while (x <= 4)
            {
                Query(x);
                x++;
            }
        }

        public static void Query(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("What is your name?");
                    answer1 = Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("What is your favorite color?");
                    answer2 = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("What is your favorite animal?");
                    answer3 = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("What is your favorite band?");
                    answer4 = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine($"{answer1} was the most radical person to have ever lived. There was a big concert playing across the country!\nNo way was {answer1} going to miss out. {answer1} had no money though, so they decided to hike it!\nAfter 100 miles, a weird {answer2} bus pulled up. The driver wasn't a person! They more of the {answer3} persuasion.\n\"You must be {answer1}, the most radical person to ever live! We're all going to the awesome concert. Did you want a ride?\"\n{ answer1} nodded in radical approval and got on the bus. The weird {answer2} bus drove all the way to the concert.\n{answer4} was the main act! It was a most radical experience.");
                    break;
            }
        }
    }
}
