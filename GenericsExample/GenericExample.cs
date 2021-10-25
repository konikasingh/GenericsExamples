using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class GenericMaxNumber<T> where T : IComparable
    {
        /// <summary>
        /// finding max value in array and sorting them using sort function
        /// </summary>
        public T[] Value;

        public GenericMaxNumber(T[] value)
        {
            this.Value = value;
        }
        public T[] Sort1(T[] values)
        {
            Array.Sort(values);
            Console.WriteLine("the sorted array is :");
            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
            return values;
        }
        public T maxValue(params T[] values)
        {

            var sorted_values = Sort1(values);
            return sorted_values[^1];

        }

        public void printMaxValue()
        {
            var max = maxValue(this.Value);
            Console.WriteLine("Maximum value is:" + max);

        }
    }
}
