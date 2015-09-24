using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Class1
    {
        public int[] Reverse(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];

            int j = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                newArray[j] = numbers[i];
                j++;
            }

            return newArray;
        }
    }
}
