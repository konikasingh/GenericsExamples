using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMaxNumber<int> simple = new GenericMaxNumber<int>(25, 34, 32);
            simple.findMax();
            GenericMaxNumber<float> simple1 = new GenericMaxNumber<float>(25.20f, 25.33f, 25.12f);
            simple1.findMax();
            GenericMaxNumber<string> simple2 = new GenericMaxNumber<string>("abc", "red", "wsx");
            simple2.findMax();
            Console.ReadLine();

            /*Console.WriteLine("Enter the First number:");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int t = Convert.ToInt32(Console.ReadLine());*/



        }
    }
}
