using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the First number:");
            float f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float s = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            float t = Convert.ToSingle(Console.ReadLine());

            SimpleClass simple = new SimpleClass(f, s, t);
            simple.findMax();
        }
    }
}
