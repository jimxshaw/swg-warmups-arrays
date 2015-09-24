using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft
{
    public class Class1
    {
        public int[] RotateLeft(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];

            for (int i = 1; i < numbers.Length; i++)
            {
                newArray[i - 1] = numbers[i];
            }

            newArray[newArray.Length - 1] = numbers[0];

            return newArray;
        }
    }
}
