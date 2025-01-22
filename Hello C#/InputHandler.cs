using System;

namespace HelloCSharp
{
    class InputHandler
    {
        public InputHandler()
        {

        }

        public void GetInput()
        {
            Console.WriteLine("Option 1: Dispaly time");
            Console.WriteLine("Option 2: Display date");
            Console.WriteLine("Option 3: Display day of the week");
            Console.WriteLine("Please select an option:");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "1":
                case "one":
                case "uno":
                case "option one":
                case "option 1":
                    TimeDisplay.ShowTime();
                    break;
                case "2":
                case "two":
                case "option two":
                case "option 2":
                    DateDisplay.ShowDate();
                    break;
                case "3":
                case "three":
                case "option three":
                case "tree":
                case "option 3":
                    DayDisplay.ShowDay();
                    break;
                case "quit":
                case "leave":
                case "I want out":
                case "exit":
                    Console.WriteLine("Exiting the program, Press enter to continue...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That input is incorrect, please try again.");
                    break;
            }
        }
    }

    static class TimeDisplay
    {
        public static void ShowTime()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("hh:mm:ss tt"));
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static class DateDisplay
    {
        public static void ShowDate()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static class DayDisplay
    {
        public static void ShowDay()
        {
            Console.WriteLine("Current Day: " + DateTime.Now.ToString("dddd"));
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
