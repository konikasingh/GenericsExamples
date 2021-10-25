using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Enter the First number:");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int t = Convert.ToInt32(Console.ReadLine());

            SimpleClass simple = new SimpleClass(f, s, t);
            simple.findMax();
        }
    }
}
