using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MakePi
{
    public class Class1
    {
        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            string piString = pi.ToString().Remove(1, 1);
            char[] piCharArray = piString.ToCharArray();
            int[] piIntArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                piIntArray[i] = int.Parse(piCharArray[i].ToString());
            }

            return piIntArray;
        }
    }
}
