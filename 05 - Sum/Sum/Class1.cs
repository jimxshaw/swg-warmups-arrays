using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Class1
    {
        public int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (int element in numbers)
            {
                sum += element;
            }

            return sum;
        }
    }
}
