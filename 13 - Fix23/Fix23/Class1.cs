using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix23
{
    public class Class1
    {
        public int[] Fix23(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    newArray[i + 1] = 0;
                }
            }

            return newArray;
        }
    }
}
