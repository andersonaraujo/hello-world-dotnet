// A Hello World! program in C#.
using System;
namespace HelloWorld
{
    public class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public int getInt()
        {
            return 1;
        }
    }
}
