using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherWins
{
    public class Class1
    {
        public int[] HigherWins(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];

            int higher = 0;

            if (numbers[0] > numbers[numbers.Length - 1])
            {
                higher = numbers[0];
            }
            else
            {
                higher = numbers[numbers.Length - 1];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = higher;
            }

            return newArray;
        }
    }
}
