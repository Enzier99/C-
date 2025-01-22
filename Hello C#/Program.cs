using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHandler inputHandler = new InputHandler();
            while (true)
            {
                inputHandler.GetInput();
            }
        }
    }
}