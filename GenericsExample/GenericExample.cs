using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class GenericMaxNumber<T> where T : IComparable
    {
        public T[] Value;

        public GenericMaxNumber(T[] value)
        {
            this.Value = value;
        }
        public T maxValue(params T[] values)
        {

            foreach (var i in values)
            {
                Console.WriteLine(i);

            }
            return default;

        }

        public void printMaxValue()
        {
            var max = maxValue(this.Value);
        }

    }
}
