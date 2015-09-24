using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddle
{
    public class Class1
    {
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] newArray = new int[2];

            newArray[0] = a[1];
            newArray[1] = b[1];

            return newArray;
        }
    }
}
