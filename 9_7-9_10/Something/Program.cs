using System;
namespace Something
{
    class Program
    {

        private static string GiveMeSomething(string input)
        {
            return ($"something {input}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GiveMeSomething("is better than nothing"));
            Console.WriteLine(GiveMeSomething("Bob Jane"));
            Console.WriteLine(GiveMeSomething("something"));
        }
    }
}
