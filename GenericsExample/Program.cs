using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First string:");
            string f = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the third string:");
            string t = Console.ReadLine();

            SimpleClass simple = new SimpleClass(f, s, t);
            simple.findMax();

        }
    }
}
