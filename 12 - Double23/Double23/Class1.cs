using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double23
{
    public class Class1
    {
        public bool Double23(int[] numbers)
        {
            int twoCount = 0;
            int threeCount = 0;

            bool arrayResult = false;

            foreach (int element in numbers)
            {
                if (element == 2)
                {
                    twoCount++;
                }
                if (element == 3)
                {
                    threeCount++;
                }
            }


            if (twoCount == 2 || threeCount == 2)
            {
                arrayResult = true;
            }

            return arrayResult;
        }
    }
}
