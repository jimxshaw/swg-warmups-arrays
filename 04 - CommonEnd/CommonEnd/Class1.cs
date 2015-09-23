using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEnd
{
    public class Class1
    {
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a.Length >= 1 && b.Length >= 1)
            {
                if ((a[0] == b[0]) || (a[a.Length - 1] == b[b.Length - 1]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
