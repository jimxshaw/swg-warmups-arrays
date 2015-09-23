using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameFirstLast
{
    public class Class1
    {
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
