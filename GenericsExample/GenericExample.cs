using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class GenericMaxNumber<T> where T : IComparable
    {
        public T first, second, third;

        public GenericMaxNumber(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public void findMax1()
        {

            //here checking the greater number among three using compareTo() method

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("the {0} is greater", first);//if first is greater 
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("the {0} is greater", second);//if second is greater
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("the {0} is greater", third);//if third is greater
            }
            else
            {
                Console.WriteLine("numbers are equal");//else all number are equal
            }
        }
    }
}

