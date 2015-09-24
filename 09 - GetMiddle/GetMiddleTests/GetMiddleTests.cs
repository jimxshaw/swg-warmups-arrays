using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GetMiddle;

namespace GetMiddleTests
{
    [TestFixture]
    public class GetMiddleTests
    {
        private Class1 _class1;

        [SetUp]
        public void BeforeTest()
        {
            _class1 = new Class1();
            Console.WriteLine("SetUp Called.");
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]
        public void GetMiddle_Arrays_ReturnArray(int[] a, int[] b, int[] expectedResult)
        {
            int[] result = _class1.GetMiddle(a, b);

            Assert.AreEqual(result, expectedResult);

            Console.WriteLine(expectedResult);
        }
    }
}
