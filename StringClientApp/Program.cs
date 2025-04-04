using StringLib;

namespace StringClientApp
{
    internal class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();

            if (input.StartsWithUpperCase())
            {
                Console.WriteLine("The string starts with an uppercase.");
            }
            else
            {
                Console.WriteLine("The string starts with an lowercase.");
            }
        }
    }
}