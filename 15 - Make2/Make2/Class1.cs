using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make2
{
    public class Class1
    {
        public int[] Make2(int[] a, int[] b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            int[] combinedAandB = new int[a.Length + b.Length];
            int[] newArray = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                combinedAandB[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                combinedAandB[lengthA + i] = b[i];
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = combinedAandB[i];
            }

            return newArray;

        }
    }
}
