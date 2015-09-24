using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Make2;

namespace Make2Tests
{
    [TestFixture]
    public class Make2Tests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void Make2_Arrays_ReturnArray(int[] a, int[] b, int[] expectedResult)
        {
            int[] result = _class1.Make2(a, b);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
