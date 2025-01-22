using System;

namespace HelloCSharp
{
    class InputHandler
    {
        string input;
        public InputHandler()
        {
           input = string.Empty;
        }

        public void GetInput()
        {
            if(input == string.Empty)
            {
            Console.WriteLine("Option 1: Display time");
            Console.WriteLine("Option 2: Display date");
            Console.WriteLine("Option 3: Display day of the week");
            Console.WriteLine("Please select an option:");
            input = Console.ReadLine() ?? string.Empty;
            }
            switch (input.ToLower())
            {
                case "1":
                case "one":
                case "uno":
                case "option one":
                case "option 1":
                    input = TimeDisplay.Show();
                    break;
                case "2":
                case "two":
                case "duo":
                case "option two":
                case "option 2":
                    input = DateDisplay.Show();
                    break;
                case "3":
                case "three":
                case "option three":
                case "tree":
                case "option 3":
                    input = DayDisplay.Show();
                    break;
                case "quit":
                case "leave":
                case "I want out":
                case "I want to leave":
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

    interface IDisplay
    {
        string Show();
        static string continueMessage = "Press Enter to continue or select a different option...";
    }

    static class TimeDisplay
    {
        public static string Show()
        {
            Console.WriteLine("Current Time: " + DateTime.Now.ToString("hh:mm:ss tt"));
            Console.WriteLine(IDisplay.continueMessage);
            return Console.ReadLine() ?? string.Empty;
        }
    }

    static class DateDisplay
    {
        public static string Show()
        {
            Console.WriteLine("Current Date: " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine(IDisplay.continueMessage);
            return Console.ReadLine() ?? string.Empty;
        }
    }

    static class DayDisplay
    {
        public static string Show()
        {
            Console.WriteLine("Current Day: " + DateTime.Now.ToString("dddd"));
            Console.WriteLine(IDisplay.continueMessage);
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
