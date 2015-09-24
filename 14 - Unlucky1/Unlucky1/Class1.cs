using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unlucky1
{
    public class Class1
    {
        public bool Unlucky1(int[] numbers)
        {
            bool unlucky1 = false;

            if ((numbers[0] == 1 && numbers[1] == 3) || (numbers[1] == 1 && numbers[2] == 3) ||
                (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3))
            {
                unlucky1 = true;
            }

            return unlucky1;
        }
    }
}
