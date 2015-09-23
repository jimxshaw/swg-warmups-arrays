using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLast6
{
    public class Class1
    {
        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }

            return false;
        }
    }
}
