using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasEven
{
    public class Class1
    {
        public bool HasEven(int[] numbers)
        {
            bool hasEven = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    hasEven = true;
                }
            }

            return hasEven;
        }
    }
}
