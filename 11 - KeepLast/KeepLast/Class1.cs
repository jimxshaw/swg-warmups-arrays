using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepLast
{
    public class Class1
    {
        public int[] KeepLast(int[] numbers)
        {
            int[] newArray = new int[numbers.Length * 2];

            newArray[newArray.Length - 1] = numbers[numbers.Length - 1];

            return newArray;
        }
    }
}
